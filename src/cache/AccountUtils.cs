using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchCount = "strict-1";
        public const double MaxScore = 36.1;
        public const long LimitLayout = 1639;
        public const long StepScore = 5223;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Done,
            Synced,
        }
    }
}
