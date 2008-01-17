using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Stale,
            Pending,
            Failed,
            Idle,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 719;
        public const long RetrySize = 4465;
        public const double MinCommits = 20.41;
    }
}
