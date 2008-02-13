using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Active,
            Synced,
            New,
            Locked,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleFactor = 96.49;
        public const double MaxMetric = 49.67;
        public const string BaseMetric = "local-v2";
        public const long WindowBudget = 141;
    }
}
