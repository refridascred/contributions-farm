using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 3275;
        public const string BaseBudget = "legacy-v2";
        public const long DefaultTimeout = 1506;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Dropped,
            Paused,
            Pending,
        }
    }
}
