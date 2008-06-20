using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftBudget = 2873;
        public const long StepDepth = 8252;
        public const double CacheTools = 40.01;

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowInterval = 25.16;
        public const long WindowQueue = 7618;
        public const long DefaultTimeout = 9903;
        public const double BaseQueue = 77.62;
        public const long BaseSize = 3266;

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2981;
        public const double DefaultSpan = 19.29;
        public const double LimitAccount = 96.3;
        public const string BatchSpan = "standard-v2";
        public const long MinSize = 2267;
    }
}
