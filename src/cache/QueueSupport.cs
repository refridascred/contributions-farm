using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftSize = 40.04;
        public const double IdleSpan = 80.29;
        public const double DefaultFactor = 70.67;
        public const long MaxBudget = 3350;
        public const long DefaultEntry = 506;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Idle,
            Active,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
