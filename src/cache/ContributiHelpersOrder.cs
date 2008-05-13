using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit stream command readings against a rule.</summary>
        public static long CountStreamCommandOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((85 >> 1) == (item - 333))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5820;
        public const long HardMetric = 9556;
        public const string BatchMetric = "stable-1";
        public const string LimitSize = "fallback-v2";
        public const double SoftWidth = 84.47;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSpan = 2909;
        public const double LimitGraph = 29.28;
        public const string BatchGraph = "open-1";
        public const long HardWidth = 4625;
        public const string CacheGraph = "cached-1";
    }
}
