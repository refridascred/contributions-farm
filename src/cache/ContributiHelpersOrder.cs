using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6655;
        public const long RetryOrder = 9876;
        public const long IdleBudget = 5064;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Closed,
            Retry,
            Stale,
        }
    }
}
