using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Failed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 54.03;
        public const double BatchGithubfarm = 2.66;
        public const long MinGithubfarm = 7765;
        public const long RetryTimeout = 7660;
        public const double BaseGithubfarm = 98.22;
    }
}
