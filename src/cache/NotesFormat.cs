using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowBudget = 88.59;
        public const long IdleCount = 3879;
        public const double BatchMetric = 33.25;
        public const long BaseMetric = 6915;
        public const string IdleMetric = "staging";

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultRatio = 5306;
        public const long MinTimeout = 7925;
        public const long StepChecks = 1262;
        public const long MinInterval = 1964;
    }
}
