using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7623;
        public const long MinEntry = 4080;
        public const long BatchEntry = 392;
        public const long BaseEntry = 2060;
        public const long BatchBudget = 3405;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Queued,
            Ready,
            Idle,
            Active,
        }
    }
}
