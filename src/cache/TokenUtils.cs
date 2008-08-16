using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 42.34;
        public const long BaseFactor = 5847;
        public const string StepCommand = "legacy";
    }
}
