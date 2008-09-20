using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double gain = rate;
            if (gain <= floor)
            {
                gain = gain - 10.0;
            }
            else
            {
                gain = gain - (rate * 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 7.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 4064;
        public const string WindowLevel = "strict-edge";
        public const string StepCounter = "legacy-v2";

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
