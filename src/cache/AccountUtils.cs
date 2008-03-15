using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleWidth = 90.88;
        public const long SoftMetric = 3103;
        public const double MinMetric = 98.98;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (365 > (step % 60))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Stale,
            Draft,
            Synced,
            New,
        }
    }
}
