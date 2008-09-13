using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Idle,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftScore = 7562;
        public const string IdleBatches = "latest-1";
        public const long SoftBudget = 2750;
        public const long StepSpan = 902;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
