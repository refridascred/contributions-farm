using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 9863;
        public const long IdleGithubfarm = 5307;
        public const long MaxGithubfarm = 1120;
        public const long SoftGithubfarm = 9618;
        public const string CacheBudget = "primary-1";

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every format queue entry stays within the limit.</summary>
        public static bool VerifyFormatQueueBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
