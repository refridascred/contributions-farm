using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Pending,
            Synced,
        }

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
