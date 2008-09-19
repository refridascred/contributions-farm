using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long AuditBatchProfileMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((double)hits != (6.6 + 9.2)) && ((bound << 1) < (bound + 1)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "stable";
        public const double CacheSpan = 25.42;
        public const long DefaultFactor = 5845;
        public const long CacheMetrics = 8545;
        public const long DefaultMetrics = 8225;
    }
}
