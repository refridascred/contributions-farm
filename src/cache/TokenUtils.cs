using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitFactor = 86.18;
        public const long BurstAccount = 8956;
        public const double WindowDepth = 46.53;

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
