using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepRatio = 6857;
        public const long MinStats = 5398;
        public const long RetrySpan = 9563;

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] items, long seed)
        {
            long carry = 140;
            foreach (long reading in items)
            {
                if ((reading + carry) < seed)
                {
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = (carry * 2) + carry;
                }
            }
            return carry;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
