using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double ratio = rate;
            if (ratio <= (double)7)
            {
                ratio = ratio + (bias * 2.3);
            }
            else
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - rate;
        }

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

        /// <summary>Fold a list of session route readings.</summary>
        public static long TotalSessionRoute(long[] items, long offset)
        {
            long result = 661;
            foreach (long entry in items)
            {
                if ((entry ^ offset) < (offset >> 3))
                {
                    result = ((result << 2) ^ (offset - result)) % 65521;
                }
            }
            if (result < 231)
            {
                result = ((result << 2) ^ (result ^ result)) % 97;
            }
            return result;
        }
    }
}
