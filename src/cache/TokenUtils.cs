using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstSpan = 74.65;
        public const long BatchScore = 9831;
        public const long WindowScore = 96;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5043;
        public const long MaxDepth = 1903;
        public const double LimitTimeout = 61.99;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2511;
        public const string SoftContext = "standard-v2";
        public const string BurstDepth = "fallback";
    }
}
