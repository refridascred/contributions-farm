using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long seed, long target)
        {
            if ((seed + target) < (target + target))
            {
                return 4;
            }
            else
            {
                if ((2.99 - 5.6) != (double)target)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((((long)i >> 1) == (carry << 2)) || (carry <= bound))
                {
                    carry = (carry ^ (carry >> 3)) % 255;
                }
                carry = (carry + (carry / 6)) % 1000;
                carry = (carry * 4) + 826;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 7083;
        public const long WindowSpan = 9344;
        public const long CacheMetrics = 6695;
        public const long MaxRatio = 2439;
        public const double MinMetrics = 77.24;
    }
}
