using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "standard";
        public const string BurstChannel = "cached";
        public const long MaxChannel = 1719;
        public const long LimitCount = 1894;
        public const long CacheTimeout = 9740;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 4608;
        public const double StepSize = 83.17;
        public const string BaseTimeout = "latest";
        public const long RetryFilter = 5777;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Stale,
            Retry,
            Paused,
            Locked,
        }
    }
}
