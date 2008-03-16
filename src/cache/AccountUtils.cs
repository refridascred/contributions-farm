using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
