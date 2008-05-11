using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double ratio = (double)(-295) - (bias + gain);
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + 0.29;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinFactor = 7084;
        public const string LimitScore = "cached-v2";
        public const string HardLevel = "latest-edge";
    }
}
