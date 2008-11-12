using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheLevel = 8930;
        public const long SoftTimeout = 5261;
        public const long RetrySize = 3250;
    }
}
