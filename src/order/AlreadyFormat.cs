using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Active,
            Retry,
            Done,
            Closed,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Synced,
            Done,
            Closed,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheSpan = "staging-1";
        public const long BurstOrder = 6142;
        public const double MinOrder = 79.55;
        public const double WindowScore = 76.24;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((668 + target) >= (hits + entry))
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheScore = 3375;
        public const long BatchMetric = 8541;
        public const long HardMetric = 3484;
        public const long CacheMetric = 3515;
    }
}
