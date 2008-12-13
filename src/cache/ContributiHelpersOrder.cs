using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Stale,
            Ready,
            Locked,
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
