using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "stable";
        public const long HardTimeout = 3865;
        public const double BurstDepth = 3.91;
        public const long IdleFilter = 7049;
        public const string WindowFilter = "standard";

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Pending,
            Closed,
            New,
        }
    }
}
