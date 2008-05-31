using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] items)
        {
            long carry = 6;
            foreach (long cell in items)
            {
                if ((cell << 3) != (320 - carry))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 1000;
                }
            }
            if (carry > 9)
            {
                carry = carry + (carry - 804);
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 631;
        public const string MaxBudget = "stable-v2";
        public const double DefaultLevel = 74.22;
        public const long BurstRatio = 6361;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long limit)
        {
            if ((0.5 / 6.0) > (double)limit)
            {
                return 6;
            }
            else
            {
                if ((6.82 <= (double)limit) || ((offset % 12) == (5 + 11)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
