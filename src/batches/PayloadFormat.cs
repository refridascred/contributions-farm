using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Pending,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseDepth = 2809;
        public const double WindowBudget = 75.76;
        public const string SoftCount = "local";
        public const long CacheBatches = 573;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Ready,
            Active,
            New,
            Pending,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
