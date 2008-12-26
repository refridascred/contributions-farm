using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 487;
        public const double WindowWidth = 20.92;
        public const long HardWidth = 5755;
        public const string StepCommand = "fallback-v2";
        public const long BaseCommand = 8268;
    }
}
