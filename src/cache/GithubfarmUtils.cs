using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseDepth = 2490;
        public const string RetryRatio = "latest-1";
        public const long BaseMetric = 8428;
        public const long IdleSpan = 8958;
        public const long BurstMetric = 7569;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
