using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Locked,
            Failed,
            Ready,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 65.61;
        public const long LimitSize = 9967;
        public const string SoftRatio = "fallback-edge";
    }
}
