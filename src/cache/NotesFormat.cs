using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Queued,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 1.92;
        public const long CacheInterval = 6337;
        public const double RetryChecks = 74.49;
        public const long MinBudget = 9456;
        public const string IdleBudget = "standard";

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "local-1";
        public const long HardLevel = 3871;
        public const long BurstDepth = 2823;
        public const long IdleScore = 9987;
        public const long HardBudget = 5942;
    }
}
