using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Retry,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
