using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next report route value from a seed.</summary>
        public static long SeriesReportRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ (limit + sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardInterval = 60.98;
        public const long BaseBudget = 7088;
        public const long LimitSpan = 2423;

        /// <summary>Count the batch graph entries that pass the check.</summary>
        public static long AuditBatchGraphHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (step < (step + step))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
