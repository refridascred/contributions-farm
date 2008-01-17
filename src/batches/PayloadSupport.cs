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

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 719;
        public const long RetrySize = 4465;
        public const double MinCommits = 20.41;
    }
}
