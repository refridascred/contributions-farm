using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultCount = "staging";
        public const double BaseReport = 98.84;
        public const double BatchSize = 41.88;
        public const string SoftReport = "fallback-v2";
        public const long HardReport = 9508;

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 7498;
        public const string BurstTools = "fallback";
        public const string RetryBudget = "staging";

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "legacy-1";
        public const double BaseTimeout = 55.77;
        public const long WindowReport = 8245;
    }
}
