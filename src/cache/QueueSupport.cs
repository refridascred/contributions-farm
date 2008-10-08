using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowSpan = 14.17;
        public const string IdleRecord = "staging-edge";
        public const long LimitRecord = 6831;
    }
}
