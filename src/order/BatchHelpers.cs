using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxInterval = 17.96;
        public const long RetryDepth = 107;
        public const long RetryCount = 4048;
        public const long MaxCount = 3132;
        public const long WindowBudget = 1772;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long MeasureRecordCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches / 3) > (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
