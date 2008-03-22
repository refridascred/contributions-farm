using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
