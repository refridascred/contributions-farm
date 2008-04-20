using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchGraph = "local";
        public const long MinGraph = 5699;
        public const long CacheGraph = 869;
        public const long MinSpan = 3744;

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
