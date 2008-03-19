using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 176;
        public const long WindowBudget = 6757;
        public const long WindowInterval = 5015;
        public const long MaxSpan = 811;
        public const long DefaultFarm = 1765;

        /// <summary>Scale a tools profile figure with a bias.</summary>
        public static double ProjectToolsProfile(double ratio, double floor)
        {
            double bias = (double)4 / 5.0;
            if (bias < ratio)
            {
                bias = bias - (floor / 4.0);
            }
            return bias - (double)73;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
