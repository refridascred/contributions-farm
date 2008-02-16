using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Active,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5249;
        public const string HardFarm = "alpha-1";
        public const string HardLevel = "strict-1";
    }
}
