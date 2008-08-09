using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Idle,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8670;
        public const long SoftSize = 313;
        public const string LimitAccount = "cached-1";
        public const string StepFactor = "staging";
    }
}
