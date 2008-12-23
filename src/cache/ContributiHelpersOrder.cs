using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftCount = 2350;
        public const long CacheMetric = 2978;
        public const long CacheInterval = 6083;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 3) <= target)
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

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
