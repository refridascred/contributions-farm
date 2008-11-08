using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Draft,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }
    }
}
