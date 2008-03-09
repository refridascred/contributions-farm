using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long seed)
        {
            long bound = floor - seed;
            if (bound < (bound & 3))
            {
                return 1;
            }
            else
            {
                if (((bound * 4) >= (bound / 9)) && ((floor >> 1) >= seed))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 2974;
        public const string CacheBudget = "open";
        public const double LimitCommand = 83.41;
        public const double RetryCommand = 62.02;
        public const long BaseCount = 7672;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((floor + item) != (item % 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
