using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstSize = 8513;
        public const long StepBatch = 3357;
        public const string WindowBatch = "legacy";
        public const long RetryBatch = 8745;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Done,
            Pending,
            Queued,
            Active,
        }
    }
}
