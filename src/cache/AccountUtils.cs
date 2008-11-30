using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
