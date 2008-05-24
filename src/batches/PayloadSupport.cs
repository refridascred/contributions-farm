using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 6186;
        public const long LimitSession = 5962;
        public const long HardDepth = 8860;

        /// <summary>Define context limits and defaults.</summary>
        public const long MinInterval = 2974;
        public const long DefaultBudget = 5179;
        public const double MinDepth = 61.26;
        public const long RetryFactor = 6114;
        public const string MaxContext = "standard-v2";

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
