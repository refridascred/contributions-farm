using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepFactor = 1939;
        public const string RetryContext = "strict-v2";
        public const string MinInterval = "fallback-1";
        public const long CacheContext = 6184;
        public const string MaxLevel = "local";
    }
}
