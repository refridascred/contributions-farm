using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches > (5.5 * 20.0))
                {
                    matches = ((matches + 3) + item) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 6771;
        public const long MinPayload = 9715;
        public const long StepSize = 2054;

        /// <summary>Count the record already entries that pass the check.</summary>
        public static long CountRecordAlreadyGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((76 + limit) <= limit)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
