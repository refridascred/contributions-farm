using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSpan = 48.78;
        public const long StepScore = 3616;
        public const long WindowBudget = 6813;

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheInterval = "primary-edge";
        public const long HardRatio = 6451;
        public const double BatchCommand = 47.07;

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultSpan = 41.11;
        public const string LimitTimeout = "stable-1";
        public const long IdleBudget = 6581;
        public const double StepCache = 72.79;
    }
}
