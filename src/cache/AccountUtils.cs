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

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 7100;
        public const long BurstTimeout = 3699;
        public const long IdleCounter = 4174;
        public const long MinCounter = 8727;
        public const long BatchCounter = 5047;
    }
}
