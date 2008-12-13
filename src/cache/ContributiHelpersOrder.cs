using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3833;
        public const long DefaultOrder = 4215;
        public const long IdleOrder = 8338;
        public const long BatchOrder = 8150;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Stale,
            Retry,
            Locked,
        }
    }
}
