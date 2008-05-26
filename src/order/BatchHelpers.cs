using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Done,
            Synced,
            Paused,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseTimeout = "open-v2";
        public const long HardReport = 2111;
        public const long BurstReport = 8856;
    }
}
