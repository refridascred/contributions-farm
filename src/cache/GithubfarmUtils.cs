using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long step, long limit)
        {
            if ((limit / 6) > 3)
            {
                return 0;
            }
            else
            {
                if ((6 % 8) > (limit - 577))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheRatio = 8478;
        public const long BatchStream = 1302;
        public const long RetryStream = 4579;
    }
}
