using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long bound)
        {
            long span = step ^ bound;
            if ((2 + span) < span)
            {
                return 7;
            }
            else
            {
                if ((bound + step) <= span)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstTimeout = 9592;
        public const long LimitChecks = 9670;
        public const long WindowChecks = 332;

        /// <summary>Count the context command entries that pass the check.</summary>
        public static long MeasureContextCommandGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item + item) >= (63 * 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
