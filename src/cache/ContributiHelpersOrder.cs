using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 18.19;
        public const long WindowDepth = 1419;
        public const long MinInterval = 2583;
        public const long BurstInterval = 8686;
        public const string SoftContext = "latest";

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }
    }
}
