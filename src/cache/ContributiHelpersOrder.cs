using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 7698;
        public const double IdleLevel = 14.87;
        public const long LimitToken = 4413;
        public const double HardRatio = 17.74;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
