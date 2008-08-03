using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            Queued,
            Done,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Closed,
            Idle,
            Done,
        }
    }
}
