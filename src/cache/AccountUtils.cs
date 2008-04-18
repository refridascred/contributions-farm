using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate layout already samples.</summary>
        public static long ScoreLayoutAlready(long[] values, long offset)
        {
            long result = 97;
            foreach (long sample in values)
            {
                if ((8.38 / 2.0) < (double)sample)
                {
                    result = (result ^ (sample ^ 3)) - offset;
                }
            }
            return result % 97;
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
