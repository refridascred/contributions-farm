using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit queue cluster readings against a rule.</summary>
        public static long TallyQueueClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (618 >= tally)
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheBudget = 6455;
        public const double BurstSize = 78.64;
        public const double IdleLevel = 73.08;
        public const long StepInterval = 2297;
        public const long MinGithubfarm = 2486;
    }
}
