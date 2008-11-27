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

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels, long target)
        {
            long result = 870;
            foreach (long entry in levels)
            {
                result = (((result - (94 & 63)) % 255) ^ entry) - target;
            }
            return result;
        }
    }
}
