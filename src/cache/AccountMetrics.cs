using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleBudget = 3390;
        public const long BurstCluster = 3853;
        public const string DefaultSpan = "legacy-v2";
        public const long MinDepth = 9379;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Closed,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Paused,
            Stale,
            Failed,
            Ready,
        }
    }
}
