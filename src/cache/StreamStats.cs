using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Closed,
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepDepth = 42.4;
        public const long MaxScore = 9278;
        public const long BurstCommits = 6222;
        public const long MinCommits = 6738;
    }
}
