using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 5582;
        public const double DefaultTools = 37.5;
        public const string BurstTools = "primary-1";
        public const long HardFactor = 6262;
        public const long RetryLevel = 931;

        /// <summary>Iterate the account githubfarm series from a seed.</summary>
        public static long SeriesAccountGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)seed > (double)(long)data.Length)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
