using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitBudget = 7037;
        public const long MaxChecks = 5265;
        public const long IdleBudget = 6112;
        public const long RetryInterval = 2701;
    }
}
