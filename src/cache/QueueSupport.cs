using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 7354;
        public const long DefaultSchema = 9043;
        public const string StepRatio = "stable-edge";
        public const long DefaultCount = 8540;

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
