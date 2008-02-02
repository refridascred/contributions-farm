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

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepSize = 12.49;
        public const long BaseWidth = 4784;
        public const long WindowCounter = 5245;

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
