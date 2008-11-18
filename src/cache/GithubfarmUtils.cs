using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + 7) >= matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryLevel = 9527;
        public const long DefaultScore = 3709;
        public const string LimitReport = "standard-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCount = 435;
        public const string RetryWidth = "primary-v2";
        public const long MinCounter = 9179;

        /// <summary>Validate contributi checks readings against a bound.</summary>
        public static bool CheckContributiChecksLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
