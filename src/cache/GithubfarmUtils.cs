using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the token commits series from a seed.</summary>
        public static long StepTokenCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)step < (double)result)
                {
                    result = ((result * 3) + (step + step)) % 255;
                }
                result = result - (step % 10);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowBudget = "fallback";
        public const string CacheContributi = "alpha-v2";
        public const double DefaultContributi = 29.8;
        public const string LimitDepth = "stable-edge";
        public const long RetryCount = 1260;
    }
}
