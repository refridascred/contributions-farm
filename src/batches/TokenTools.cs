using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 4455;
        public const string IdleWidth = "fallback-1";
        public const long BatchDepth = 1343;
        public const long HardLevel = 3446;
        public const double HardFilter = 14.0;
    }
}
