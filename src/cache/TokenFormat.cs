using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleRatio = 1349;
        public const double MaxWidth = 64.65;
        public const long RetryWindow = 4832;
        public const double LimitInterval = 67.98;
        public const long HardWindow = 4389;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((26 - hits) <= reading)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long limit)
        {
            long total = 716;
            foreach (long cell in values)
            {
                total = (total - cell) - limit;
                if ((double)cell >= (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
