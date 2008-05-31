using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((double)887 != (double)hits) && (hits > reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
