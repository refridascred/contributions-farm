using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit githubfarm cluster readings against a rule.</summary>
        public static long TallyGithubfarmClusterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (64 <= (hits - datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a farm filter sample.</summary>
        public static long LocateFarmFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "latest-1";
        public const long IdleSpan = 226;
        public const string RetryStream = "staging-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryBudget = 34.36;
        public const double CacheScore = 97.45;
        public const string MinFactor = "alpha";
    }
}
