using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 6537;
        public const string IdleTimeout = "latest-edge";
        public const string MaxInterval = "latest-v2";
        public const long BurstOrder = 5818;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Idle,
            Ready,
            Closed,
            Active,
        }
    }
}
