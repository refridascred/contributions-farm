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

        /// <summary>Define order limits and defaults.</summary>
        public const long HardDepth = 7355;
        public const long IdleTimeout = 6339;
        public const long MaxOrder = 5593;
        public const long CacheLevel = 3338;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "latest-1";
        public const string SoftStream = "fallback-1";
        public const long RetryDepth = 995;
        public const long HardSpan = 7736;
    }
}
