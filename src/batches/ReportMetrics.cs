using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleDepth = 36.77;
        public const double HardQueue = 84.92;
        public const long MaxFactor = 3296;
        public const string WindowQueue = "staging-1";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
