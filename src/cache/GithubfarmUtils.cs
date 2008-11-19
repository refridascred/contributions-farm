using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 23.55;
        public const double BaseMetrics = 42.94;
        public const string BatchSpan = "alpha-v2";
        public const double BurstTimeout = 89.53;
        public const string MaxBudget = "stable";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8283;
        public const long HardRatio = 6622;
        public const string RetryGithubfarm = "local-1";
        public const long BurstSize = 9422;
        public const long IdleRatio = 8758;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
