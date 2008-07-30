using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 5254;
        public const string HardContributi = "alpha-edge";
        public const long DefaultScore = 2531;
        public const long RetryBudget = 9441;
        public const long SoftContributi = 3729;
    }
}
