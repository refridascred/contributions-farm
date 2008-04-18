using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool ValidateAccountTokenLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 4482;
        public const long LimitBudget = 9993;
        public const double IdleWindow = 64.41;
    }
}
