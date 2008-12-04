using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches < target) && ((58 % 12) <= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 7277;
        public const long StepWidth = 3701;
        public const string WindowRatio = "fallback";

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ (801 ^ (long)i);
                if ((7 <= target) && (((-792) - mark) < (target >> 3)))
                {
                    mark = (mark ^ (mark + target)) % 255;
                    mark = (mark + target) % 255;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every githubfarm cache entry stays within the limit.</summary>
        public static bool GuardGithubfarmCacheLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
