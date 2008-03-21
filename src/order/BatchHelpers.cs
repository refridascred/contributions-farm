using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleBudget = "latest-v2";
        public const string RetryNotes = "primary-edge";
        public const double MinNotes = 55.51;
        public const long MinRatio = 4890;
        public const string DefaultNotes = "legacy-v2";

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Active,
            Closed,
            Stale,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }
    }
}
