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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (result + offset)) % 97;
                if ((double)result != (2.94 * 7.4))
                {
                    result = (result * 5) + offset;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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
