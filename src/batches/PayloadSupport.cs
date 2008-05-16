using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
