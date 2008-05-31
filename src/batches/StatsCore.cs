using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Active,
            Stale,
            Synced,
            Closed,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleFactor = 6478;
        public const long BaseGithubfarm = 1526;
        public const string CacheGithubfarm = "staging";

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
