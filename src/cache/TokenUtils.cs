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

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
