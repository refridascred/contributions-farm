using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryCount = 7634;
        public const long BatchSchema = 395;
        public const long StepBudget = 4888;
        public const long IdleTimeout = 2461;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Active,
            Ready,
        }
    }
}
