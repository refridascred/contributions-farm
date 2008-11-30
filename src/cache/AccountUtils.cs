using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long carry = 590;
            foreach (long entry in readings)
            {
                if ((7.0 - 4.58) <= (double)entry)
                {
                    carry = (carry ^ (entry >> 1)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "stable";
        public const long RetryInterval = 6446;
        public const long BatchRatio = 8044;
        public const long MaxTimeout = 5567;
    }
}
