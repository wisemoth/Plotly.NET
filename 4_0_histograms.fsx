(**
// can't yet format YamlFrontmatter (["title: Histograms"; "category: Distribution Charts"; "categoryindex: 5"; "index: 1"], Some { StartLine = 2 StartColumn = 0 EndLine = 6 EndColumn = 8 }) to pynb markdown

# Histograms

[![Binder](https://plotly.net/img/badge-binder.svg)](https://mybinder.org/v2/gh/plotly/Plotly.NET/gh-pages?filepath=4_0_histograms.ipynb)&emsp;
[![Script](https://plotly.net/img/badge-script.svg)](https://plotly.net/4_0_histograms.fsx)&emsp;
[![Notebook](https://plotly.net/img/badge-notebook.svg)](https://plotly.net/4_0_histograms.ipynb)

*Summary:* This example shows how to create a one-dimensional histogram of a data samples in F#.

let's first create some data for the purpose of creating example charts:

*)
open Plotly.NET 

let rnd = System.Random()
let x = [for i=0 to 500 do yield rnd.NextDouble() ]
(**
A histogram consisting of rectangles whose area is proportional to the frequency of a variable and whose width is equal to the class interval.
The histogram chart represents the distribution of numerical data and can be created using the `Chart.Histogram` function:.
*)
let histo1 =
    x
    |> Chart.Histogram
    |> Chart.withSize(500.,500.)(* output: 
<div id="8dca9f03-0df4-4e81-94a6-3acaf1624c71" style="width: 500px; height: 500px;"><!-- Plotly chart will be drawn inside this DIV --></div>
<script type="text/javascript">

            var renderPlotly_8dca9f030df44e8194a63acaf1624c71 = function() {
            var fsharpPlotlyRequire = requirejs.config({context:'fsharp-plotly',paths:{plotly:'https://cdn.plot.ly/plotly-latest.min'}}) || require;
            fsharpPlotlyRequire(['plotly'], function(Plotly) {

            var data = [{"type":"histogram","x":[0.6750894955709063,0.6791322141322923,0.7793709606767497,0.03334985069620882,0.49050145945069445,0.4691669361056606,0.7474922210664918,0.15879865044671979,0.1665218240425558,0.8219746294533715,0.019673694399964855,0.9232147289082476,0.2339083525510078,0.6007110851820144,0.9216120079726037,0.6457346340854347,0.013105711440139316,0.4014716289944349,0.6363169958984093,0.44109316656416897,0.07004885844422917,0.04877386477253114,0.2355977111661796,0.8045397781788091,0.17410136301727097,0.5614314342669358,0.45454283778301574,0.15496160050619467,0.5911622809205028,0.8461848398885619,0.3781019967878712,0.4258253282987631,0.4153303585086625,0.656796531126274,0.13876953960339053,0.6595375806370459,0.3554726631173271,0.754256537069686,0.01820513606919215,0.9864909858379937,0.16420272186594212,0.3460074925543775,0.3157133750225014,0.03924699362332327,0.8571988585671405,0.29559461134280757,0.984198567450139,0.6176182476885702,0.017758435112311708,0.6483815338687885,0.0698190057044006,0.9739826600877487,0.290371035360904,0.8445344939103976,0.3277086924424901,0.626315630798375,0.4435345029661127,0.9748311824979405,0.8592484876789378,0.9290700251837587,0.014624098322644875,0.5925306205602971,0.5676363695262169,0.32033698415399386,0.44387263266550037,0.5938483661012018,0.5078843703995851,0.5771118214247337,0.46194154557862394,0.26207442733555775,0.2902619709681077,0.2588491743704533,0.38326649292524273,0.6498260100604156,0.2768904446982268,0.7240413658898517,0.7330604897500298,0.19635071754285632,0.9473409196116687,0.8785067516744633,0.5772328668167968,0.8369245900944455,0.13720316539388297,0.9427807470517143,0.7763658341841613,0.4041193367001225,0.1354542929378591,0.5707958645982648,0.32908783868378394,0.5124539088050154,0.21600307767093324,0.3806414806193865,0.8950080493907482,0.08913511088543344,0.9718668875153488,0.571672101305645,0.7783711230281606,0.9953763908685075,0.5953743609578229,0.26335049246593867,0.7877102409432224,0.40708674602540523,0.15567670210994627,0.7556840077767539,0.35811956290068087,0.8109698313339473,0.590716167162506,0.6405450253004884,0.5676440492121708,0.6036673265526384,0.8932551410483454,0.24718378542325636,0.027490262886271936,0.9807417360044745,0.35183715836696194,0.17769950822819933,0.45532745516641415,0.6248556224745025,0.5439711499698325,0.03975329596537785,0.4583940731633427,0.9370885058013203,0.24802398274094983,0.9494876367736085,0.04607134966462448,0.9096204903487212,0.36384112497970517,0.2941313820398093,0.6779591225450669,0.7052183433925818,0.945670242861691,0.7376840988815222,0.6009763565850335,0.68399042714573,0.09079651073124097,0.17014612079139152,0.6812478879844993,0.381519157617129,0.5846611841510335,0.965396002850214,0.8134031695376165,0.49490926763737075,0.003151815386094067,0.7254205121311454,0.6191987677566702,0.9688192922476769,0.3531512177331146,0.9142663133862737,0.7372979525184715,0.7941673792871494,0.11634464613923089,0.153515500553658,0.45140524089867495,0.5556210649924451,0.804956419302596,0.8506217351419021,0.1590627632844554,0.2061890653363378,0.7096126581121295,0.4484990725519597,0.4471287063542421,0.2965847851226967,0.9625859027554216,0.862425705819589,0.6579970836909474,0.15557104216682308,0.6462074288382229,0.34349983574054194,0.8899452252732335,0.18169103757557042,0.49645162024370004,0.07380829754928514,0.040194438323469105,0.5785751471196185,0.22635012642776134,0.9634848055259719,0.9339366904152262,0.5226034706098044,0.3302888690169383,0.07725205741694759,0.5564692726156065,0.44957481159343143,0.5568334295213379,0.8837917432579173,0.5888736972533509,0.7921547423080331,0.2862788579828473,0.04535529159258832,0.879034007843134,0.24017477558933886,0.011083357506936117,0.47505882264816146,0.6719064995049995,0.1361621115990738,0.5182672964959719,0.5168183844149198,0.5323233648819492,0.1407261095665051,0.06742342844019804,0.46362772558984705,0.3226118634094539,0.00965138199257263,0.024321088113040238,0.555606914942901,0.29771575904344943,0.04253634858994575,0.1133210622301889,0.8728300937790564,0.32927093856468376,0.841471613776624,0.9166850447266759,0.6364592926746511,0.8759001963193995,0.632360600695182,0.8920297999363531,0.9975538947608107,0.7397513556013589,0.0787941594975042,0.273552008566238,0.8658423413829144,0.8692921841839758,0.6008521372456347,0.464465827897408,0.6497704496838946,0.1706076800686343,0.02139279759553857,0.40190179804428566,0.9040323267243953,0.06030785062364668,0.7095317420128415,0.43116144064402273,0.7932105808487211,0.45518004216960634,0.8666611434270912,0.7546401940074936,0.5468178906230339,0.4252537234803912,0.001226514578436741,0.5860759842144679,0.5463373486634052,0.6788336800778442,0.41344876420379095,0.7160843530279045,0.03756239406650998,0.323489730862663,0.37462406483228505,0.5991586263287619,0.03954589880981757,0.24413231166272067,0.5207134017351611,0.7770670288135609,0.453529205384445,0.8671741010002672,0.20158108705728364,0.5943355414058713,0.7217597261638193,0.5451855540951647,0.3745506384291456,0.3849992348742668,0.27632296144791085,0.6406345505456601,0.20928873550579358,0.8125222431554097,0.6197391965518423,0.41031017313260126,0.12347446387795474,0.1812792505050447,0.00923905289230824,0.8777204066876882,0.3452119093133192,0.5723001712804195,0.7385248410229222,0.4927181752830363,0.7272146599028327,0.18700866130507024,0.45584341998018485,0.8847677842177301,0.426903433830898,0.3262807188212316,0.7959836152363492,0.4222341712667766,0.3623558992344681,0.6599000150616746,0.5395944488884855,0.9324647131992805,0.9776322352595778,0.926036479848454,0.25359895511232267,0.27232560202121997,0.03288046784367434,0.001632336527869262,0.05070308505124556,0.61622727970417,0.3097530227665571,0.9057027981177451,0.46954494457205054,0.6009265210483813,0.09634515647606233,0.6272522209339086,0.20001526698470826,0.19334481432724038,0.5899195734364537,0.1618254921221293,0.8989204023494014,0.9484132304547416,0.03854218779063885,0.9608110301014088,0.13995944109743436,0.014572425752213423,0.13849212142568645,0.8369919419460893,0.11828212026426667,0.04826991960791401,0.5890156196379176,0.8540887901811343,0.27827865131119206,0.5493887204441189,0.27292779426692415,0.6872744833525617,0.43267793787302355,0.19743798402950075,0.927680295392722,0.7369134508710883,0.844839938844014,0.3435795727854499,0.521597086229174,0.12229756131875215,0.1829651525164792,0.8215118617850876,0.7174637167330197,0.8549168989318036,0.7884226277416677,0.7996512128969893,0.12626545183652335,0.6026388009091088,0.8323145978303228,0.20053040711233877,0.7609796127122732,0.5911812184337439,0.8939225254086417,0.01682120515816901,0.7860770387510196,0.23902652936010926,0.1338334805955335,0.1958885258975851,0.8833502162636026,0.002433165443331546,0.027211660066252415,0.4556642325854228,0.6274241468065531,0.9201562241279316,0.3279987267814571,0.40907067312350065,0.19457428306088517,0.002577282955207528,0.26566451893451837,0.8530061225653655,0.3169855532781154,0.5553408295639515,0.42681614422556763,0.9162446264718866,0.7778458775849295,0.3184475793123467,0.29710870901919373,0.28357522249388284,0.04856931420442151,0.3186309073672774,0.9220044677713907,0.9863768187288087,0.021774192350811416,0.07774824419885326,0.7884091077318457,0.6817465758331802,0.79335195794392,0.4158567327148545,0.4113609452784811,0.6886537660326127,0.6030799702755548,0.6489514129464289,0.4602293565218474,0.5191639207858424,0.09508590125249973,0.7273009199310564,0.1940877149785346,0.797307492605088,0.5269181721503465,0.3793519546181671,0.6050769298361042,0.12368816888131581,0.3369742819745905,0.9793084752649573,0.8835448538342234,0.20563878314832168,0.16436507420817625,0.9776778989367549,0.2389753275732395,0.46762945943867296,0.9419178203409155,0.8502582581016507,0.1473192116931636,0.5647193088963252,0.08042869767194087,0.04083484133744372,0.43389004023461136,0.5496759026076998,0.13174711639608588,0.6462521509482768,0.6157187151795805,0.7787175503460306,0.5912163376767264,0.5770107529019056,0.24992615228981066,0.6680341403316865,0.09511147304210414,0.9076522234397252,0.8211587252193869,0.05054495765387312,0.12435986433381209,0.4998012164141057,0.7566570503435364,0.6692173595862544,0.7135539775311732,0.7983162988900748,0.6494025367542182,0.04246571708585402,0.19420339036462986,0.5827703245835241,0.517381501625004,0.815674059007165,0.17688140514161504,0.9437314858398081,0.7467359456916973,0.7528217121739041,0.5016322012532652,0.8955100476255221,0.43873522311390156,0.054251059915056014,0.293410879696445,0.6444118123708348,0.6655603762090022,0.8806660212020697,0.7636332394385865,0.8263593794900734,0.5324718312045894,0.7599635290726849,0.7293823229751467,0.21551071350253687,0.11052731010621754,0.256712850768451,0.156519173717368,0.18843036991936638,0.3432695951048609,0.4421166039268098,0.0936012077581143,0.4781018521069092,0.8511653313651519,0.282112398781866,0.39143230458322553,0.39142432314875736,0.35547251224306997,0.5489767918125619,0.12887064932327283,0.8000446561724155,0.6018361452044156,0.6474848518369183,0.8302748072102083,0.4971044401159065,0.1664019390784213,0.199601425416582,0.4689170003258237,0.766907665304331,0.757134077957428,0.4799480519629773,0.8342408402051036,0.8759910291414666,0.9055841201476679,0.8871945980410998,0.2658444676854855,0.8894390076815333,0.3130833941107073,0.978692676862093,0.47224301447730654,0.26066865085655294,0.659154885289797,0.9884510352222486,0.6004618907349473,0.3046193417648875,0.6592205044157898,0.023530349146356037,0.044344716260370204,0.15662282433203553,0.6628187553318304,0.9019865565476877,0.28893930012776486,0.11658358439644034,0.7517953718787969,0.9635885832661709,0.22452323428565787,0.884986979367671,0.9296887218624766,0.23227788285924023],"marker":{}}];
            var layout = {"width":500.0,"height":500.0};
            var config = {};
            Plotly.newPlot('8dca9f03-0df4-4e81-94a6-3acaf1624c71', data, layout, config);
});
            };
            if ((typeof(requirejs) !==  typeof(Function)) || (typeof(requirejs.config) !== typeof(Function))) {
                var script = document.createElement("script");
                script.setAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js");
                script.onload = function(){
                    renderPlotly_8dca9f030df44e8194a63acaf1624c71();
                };
                document.getElementsByTagName("head")[0].appendChild(script);
            }
            else {
                renderPlotly_8dca9f030df44e8194a63acaf1624c71();
            }
</script>
*)

