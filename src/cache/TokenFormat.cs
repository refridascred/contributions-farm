using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 2377;
        public const long CacheLevel = 5577;
        public const string SoftBatches = "staging-edge";
        public const long BatchBatches = 4388;
        public const long LimitRatio = 8809;
    }
}
