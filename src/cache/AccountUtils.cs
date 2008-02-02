using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((7.1 * 3.31) == (double)(long)levels.Length) && !((double)seen < (double)52))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the token schema entries that pass the check.</summary>
        public static long TallyTokenSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((0.7 - 8.36) < (double)datum) && (count < ((-5) << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long AuditBatchCacheHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((floor + floor) > floor)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
