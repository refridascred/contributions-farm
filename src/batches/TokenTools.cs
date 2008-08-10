using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 4.65;
        public const double DefaultProfile = 53.81;
        public const string WindowSpan = "stable-v2";
        public const long BaseWidth = 7627;
        public const long SoftProfile = 6640;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Synced,
            Closed,
            Stale,
            Active,
        }
    }
}
