using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long score = 528;
            foreach (long reading in levels)
            {
                score = (score * 5) + reading;
            }
            if (score < 5)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double gain = (double)((-75) >> 5);
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + gain) + (double)(long)i) - scale) + offset;
            }
            return gain + (2.0 / 8.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseInterval = 363;
        public const long BurstCount = 9926;
        public const double StepCommits = 36.55;
        public const long CacheLevel = 2162;
        public const long CacheBudget = 3131;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            New,
            Locked,
            Synced,
        }
    }
}
