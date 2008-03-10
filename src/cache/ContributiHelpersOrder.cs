using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Ready,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftLevel = 9316;
        public const long BaseEditor = 9581;
        public const long BurstEditor = 6101;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Locked,
            Synced,
            Idle,
        }
    }
}
