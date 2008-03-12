using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 395;
        public const long SoftLevel = 165;
        public const long BurstFilter = 4086;
        public const double StepFilter = 67.81;
        public const double HardBudget = 93.11;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Failed,
            Closed,
            Idle,
        }
    }
}
