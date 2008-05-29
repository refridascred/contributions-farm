using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            New,
            Active,
            Draft,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Done,
            Active,
            Synced,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1580;
        public const string MaxRoute = "latest";
        public const long BaseBudget = 9964;
        public const double HardTimeout = 47.17;
    }
}
