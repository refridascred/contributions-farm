using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            Closed,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 32.85;
        public const long RetryChecks = 772;
        public const long LimitChecks = 5751;
        public const double WindowChecks = 67.93;
        public const long HardLevel = 6619;
    }
}
