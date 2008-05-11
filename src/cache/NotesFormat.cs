using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitSize = 23.03;
        public const string IdleChecks = "legacy-v2";
        public const string MaxChecks = "alpha-v2";
        public const long BaseSpan = 17;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Closed,
            Done,
            Queued,
        }
    }
}
