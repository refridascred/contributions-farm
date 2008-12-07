using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 44.6;
        public const double BurstBudget = 12.43;
        public const long WindowFactor = 1415;
        public const long IdleTimeout = 465;
    }
}
