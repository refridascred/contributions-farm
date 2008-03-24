using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (seed - entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long state = 313;
            foreach (long entry in levels)
            {
                if ((entry >> 5) == (12 >> 2))
                {
                    state = (state - (state >> 3)) % 1000;
                }
            }
            if (state < 591)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "primary";
        public const double IdleMetric = 78.84;
        public const long BaseMetric = 6158;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "primary";
        public const long HardMetrics = 9327;
        public const long CacheMetrics = 42;
        public const long LimitMetrics = 7501;
    }
}
