using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxLevel = 47.13;
        public const double BatchInterval = 66.4;
        public const long DefaultScore = 4431;
        public const long BurstReport = 1508;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
