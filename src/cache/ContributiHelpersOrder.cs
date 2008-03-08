using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
