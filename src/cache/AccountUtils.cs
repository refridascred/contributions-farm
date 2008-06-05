using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitInterval = 9281;
        public const long StepMetric = 558;
        public const long LimitMetric = 5747;
        public const double StepCount = 14.01;
        public const long LimitScore = 4603;

        /// <summary>Audit githubfarm cache readings against a rule.</summary>
        public static long CountGithubfarmCacheMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((1 << 1) > (item ^ item))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 62.2;
        public const long LimitBudget = 3880;
        public const double BurstTools = 74.12;
        public const double MaxTools = 32.01;
        public const long StepDepth = 8754;
    }
}
