using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheWidth = "local-1";
        public const long RetrySize = 8240;
        public const long CacheCommand = 7195;
        public const long MinCommand = 1549;
        public const string BaseCommand = "stable-v2";

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseTimeout = 59.32;
        public const long BaseOrder = 4025;
        public const long RetryBudget = 8219;
        public const double CacheOrder = 16.03;
        public const long HardFactor = 9756;
    }
}
