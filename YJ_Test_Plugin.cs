using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MissionPlanner.Utilities;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using MissionPlanner;
//loadassembly: MissionPlanner.WebAPIs

namespace test
{
    public class urlmod : MissionPlanner.Plugin.Plugin
    {
        public override string Name { get; }
        public override string Version { get; }
        public override string Author { get; }

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            loopratehz = 1.0f;
            return true;
        }

        public override bool Loop()
        {
            foreach (MAVLinkInterface mav in MainV2.Comports)
            {
                Console.WriteLine($"홈 로케이션 : {mav.MAV.cs.HomeLocation}");
            }
            return true;
        }

        public override bool Exit()
        {
            return false;
        }
    }
}