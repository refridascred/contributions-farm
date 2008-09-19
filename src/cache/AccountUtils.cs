using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitFactor = 7313;
        public const long MinCluster = 5075;
        public const long DefaultLevel = 1773;
        public const string SoftFactor = "fallback-1";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Active,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Stale,
            Ready,
            Pending,
            Dropped,
            Synced,
        }
    }
}
