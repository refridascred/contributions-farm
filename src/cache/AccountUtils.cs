using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepSize = 60.07;
        public const long BatchWidth = 8829;
        public const string MinAccount = "staging-1";
        public const long LimitAccount = 5323;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Failed,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 79;
        public const long BurstLevel = 3201;
        public const string RetryFilter = "fallback";
        public const double BaseFilter = 78.69;
    }
}
