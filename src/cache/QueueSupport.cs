using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5360;
        public const string IdleRatio = "staging-edge";
        public const long MaxSession = 2677;
        public const long BurstSession = 1294;
        public const long RetrySession = 5052;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Ready,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
