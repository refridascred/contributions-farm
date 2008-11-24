using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 8731;
        public const long SoftFactor = 6828;
        public const long DefaultMetrics = 5804;
        public const string CacheSize = "open-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultRatio = 68.72;
        public const double BaseInterval = 71.97;
        public const long StepStream = 6422;
        public const string HardStream = "open-v2";
    }
}
