using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowDepth = 7954;
        public const double BurstCount = 73.29;
        public const string WindowFilter = "legacy-edge";

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            New,
            Draft,
            Synced,
            Idle,
        }

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

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
