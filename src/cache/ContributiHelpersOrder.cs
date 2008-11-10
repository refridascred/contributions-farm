using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 25.29;
        public const double BurstBudget = 72.26;
        public const double BaseDepth = 1.99;
        public const string HardFactor = "open";

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Ready,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
