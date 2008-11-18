using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetrySize = "latest-1";
        public const long MaxGithubfarm = 3922;
        public const double StepGithubfarm = 22.62;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
