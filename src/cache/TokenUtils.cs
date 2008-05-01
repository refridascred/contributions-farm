using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 18.43;
        public const string StepScore = "staging";
        public const long RetryWidth = 8367;
        public const string LimitRatio = "cached-v2";

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((limit * 5) > (limit % 64))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
