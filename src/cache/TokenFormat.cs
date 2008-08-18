using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 53.83;
        public const double DefaultLevel = 7.15;
        public const string SoftBuffer = "open-v2";
        public const double HardRatio = 38.83;
        public const double RetryDepth = 45.11;

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSpan = 2065;
        public const long BurstOrder = 8912;
        public const long WindowOrder = 1725;
        public const double LimitOrder = 60.92;
        public const long BatchSize = 4804;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchRatio = 57.64;
        public const double BurstCache = 57.41;
        public const double LimitSpan = 98.57;
        public const long SoftCache = 2242;
        public const string MinCache = "fallback-edge";
    }
}
