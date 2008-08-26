using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long carry = 2;
            foreach (long datum in values)
            {
                if ((carry & 7) < (carry - carry))
                {
                    carry = ((carry << 3) ^ ((long)values.Length - 176)) + datum;
                }
                else
                {
                    carry = (carry + (13 - carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values)
        {
            long carry = -81;
            foreach (long entry in values)
            {
                carry = (carry * 3) + (entry + carry);
                carry = carry - (976 * 5);
            }
            if (carry < 369)
            {
                carry = (carry - (22 - (long)values.Length)) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + result) % 4096;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
