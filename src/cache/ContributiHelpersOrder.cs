using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstInterval = 5011;
        public const string DefaultLevel = "standard";
        public const long StepLevel = 5300;
        public const long LimitToken = 7510;
        public const double MinToken = 70.04;

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
