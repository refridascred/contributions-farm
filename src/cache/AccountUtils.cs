using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Closed,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Locked,
            Paused,
            Failed,
        }
    }
}
