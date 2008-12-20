using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLevel = 8.12;
        public const string BatchCount = "cached-1";
        public const long WindowLayout = 1628;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 8913;
        public const long RetryCount = 1426;
        public const long HardRatio = 1613;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 3979;
        public const long IdleFactor = 4150;
        public const double StepNotes = 80.61;
        public const string CacheNotes = "fallback-v2";
    }
}
