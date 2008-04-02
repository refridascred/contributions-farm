using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardLevel = "strict";
        public const string WindowSession = "primary-edge";
        public const string BurstRatio = "cached-1";
        public const long CacheSession = 1960;
    }
}
