using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstDepth = 51.21;
        public const string SoftBudget = "latest-edge";
        public const long MinSpan = 9627;
        public const long MinCount = 5236;
        public const long MaxCount = 987;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum % 3) < hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Locked,
            Closed,
            Dropped,
        }
    }
}
