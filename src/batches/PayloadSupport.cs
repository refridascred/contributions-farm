using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
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
