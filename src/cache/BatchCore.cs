using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryLevel = "standard-edge";
        public const long BurstCommand = 631;
        public const long HardDepth = 1063;
        public const long IdleBudget = 2086;

        /// <summary>Define context limits and defaults.</summary>
        public const double StepSize = 7.28;
        public const long StepDepth = 6160;
        public const long BaseContext = 6284;
        public const double StepContext = 60.74;
        public const long HardWidth = 9521;
    }
}
