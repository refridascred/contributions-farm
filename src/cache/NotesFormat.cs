using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinTimeout = 91.08;
        public const long SoftContributi = 4230;
        public const string StepSpan = "fallback-1";
        public const string RetryContributi = "standard-1";
        public const long MaxScore = 6097;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Active,
            Failed,
            Dropped,
        }
    }
}
