using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 3808;
        public const long LimitDepth = 3176;
        public const long LimitContributi = 8219;
        public const double MinContributi = 51.85;
        public const long BurstLevel = 9510;

        /// <summary>Roll a order counter counter forward.</summary>
        public static long IterateOrderCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ target) % 4096;
                carry = (carry ^ ((long)i & 127)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "latest-1";
        public const string SoftStream = "fallback-1";
        public const long RetryDepth = 995;
        public const long HardSpan = 7736;
    }
}
