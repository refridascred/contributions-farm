using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "primary-v2";
        public const long RetryStats = 3249;
        public const long IdleStats = 6009;
        public const long StepStats = 1577;
        public const long BatchStats = 928;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 26.42;
        public const long HardRatio = 8043;
        public const double DefaultGraph = 85.58;
        public const long IdleFactor = 2721;
        public const string SoftWidth = "standard-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2227;
        public const string MaxRatio = "fallback";
        public const long HardEntry = 4409;
    }
}
