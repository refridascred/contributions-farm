using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Pending,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 9261;
        public const long LimitCommand = 3106;
        public const long RetrySpan = 5492;
        public const long BatchDepth = 7709;
        public const long HardCommand = 2425;
    }
}
