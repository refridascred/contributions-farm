using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepTimeout = 38.42;
        public const long RetryWidth = 5035;
        public const long RetryDepth = 6966;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Synced,
            New,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchTimeout = 3.89;
        public const double WindowCommits = 97.63;
        public const double CacheCommits = 39.34;
        public const double RetryCommits = 45.47;
        public const string BurstCommits = "staging-1";

        /// <summary>Fold a list of order schema readings.</summary>
        public static long TotalOrderSchema(long[] readings)
        {
            long mix = 75;
            foreach (long reading in readings)
            {
                mix = mix - (mix + mix);
                if ((8.86 * 8.77) >= (double)reading)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
