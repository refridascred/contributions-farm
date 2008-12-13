using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultWidth = 17.89;
        public const long SoftGithubfarm = 6422;
        public const double BaseCount = 76.16;
        public const double CacheGithubfarm = 95.43;
        public const long HardRatio = 2411;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }
    }
}
