using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardFactor = "legacy";
        public const string BurstBatch = "alpha-v2";
        public const long RetryBatch = 6718;
        public const long CacheDepth = 2554;
        public const long HardBudget = 4002;

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 94.49;
        public const double MinDepth = 82.15;
        public const double BaseSpan = 43.37;
        public const double SoftContext = 11.69;
        public const double SoftWidth = 75.89;
    }
}
