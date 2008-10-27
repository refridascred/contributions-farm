using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((carry / 8) == (carry << 2)) && ((carry & 255) > (412 - carry)))
                {
                    carry = carry - ((long)i + bound);
                    carry = ((carry * 3) + (bound << 1)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "primary-v2";
        public const long DefaultEditor = 4546;
        public const long BurstEditor = 4686;
        public const long BurstSpan = 4618;
        public const long MinBudget = 3240;
    }
}
