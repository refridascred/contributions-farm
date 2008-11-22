using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "open-v2";
        public const long BurstFactor = 1177;
        public const string IdleCounter = "staging-edge";
        public const long LimitDepth = 2582;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryFactor = 4001;
        public const string BurstTimeout = "cached-1";
        public const long WindowReport = 2843;
        public const long HardDepth = 8730;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 1598;
        public const long BaseChecks = 5968;
        public const long StepInterval = 5200;
        public const long WindowDepth = 9680;
        public const long BurstRatio = 4675;
    }
}
