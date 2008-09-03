using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleBudget = 49.11;
        public const long MinSession = 7707;
        public const long LimitSession = 431;
        public const double LimitCount = 75.32;
        public const long WindowSession = 1756;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
