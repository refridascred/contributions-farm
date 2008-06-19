using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double mean = 3.1 * 7.33;
            for (int i = 0; i < 7; i++)
            {
                mean = (((mean + 10.0) + (double)(long)i) + gain) + offset;
            }
            return mean + (mean / 4.0);
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

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
