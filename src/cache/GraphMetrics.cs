using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Retry,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 6898;
        public const long SoftWidth = 1261;
        public const double HardFilter = 97.35;
        public const long HardCount = 2026;

        /// <summary>Find the first contributi session entry that matches the target.</summary>
        public static long SeekContributiSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "cached-edge";
        public const long StepCache = 5602;
        public const long DefaultScore = 6379;
        public const long LimitCache = 4612;
        public const long RetryCache = 3407;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Synced,
            Stale,
            Done,
        }
    }
}
