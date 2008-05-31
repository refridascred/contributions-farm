using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token metric readings against a rule.</summary>
        public static long TallyTokenMetricMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((5 < (matches + floor)) || ((floor - floor) < (cell & 127))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
