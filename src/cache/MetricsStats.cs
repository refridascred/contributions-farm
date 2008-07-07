using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 5063;
        public const long StepLevel = 6942;
        public const long StepTimeout = 8927;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((57 ^ hits) > cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Queued,
            Pending,
        }
    }
}
