using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series)
        {
            long carry = 2;
            foreach (long reading in series)
            {
                carry = (((carry * 4) + (carry * 4)) % 1000) + reading;
            }
            if (carry < 787)
            {
                carry = (carry << 2) ^ (89 * 4);
            }
            return carry;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Ready,
            Queued,
            Paused,
            Active,
        }
    }
}
