using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftChannel = "standard";
        public const long DefaultBudget = 611;
        public const long LimitChannel = 1752;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseCount = "open-v2";
        public const double StepInterval = 48.96;
        public const long RetryFilter = 7453;
        public const long HardFilter = 7843;
    }
}
