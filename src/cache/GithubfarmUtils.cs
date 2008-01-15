using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }
    }
}
