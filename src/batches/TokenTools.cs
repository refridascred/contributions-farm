using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9807;
        public const long CacheFactor = 7260;
        public const double IdleTimeout = 96.3;
        public const long IdleSpan = 7725;
        public const long LimitCommand = 9312;

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
