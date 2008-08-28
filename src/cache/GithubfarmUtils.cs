using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseFactor = 4987;
        public const long MinDepth = 7860;
        public const long IdleTools = 1347;
        public const long HardFactor = 1451;
        public const string CacheTools = "strict-v2";

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double span)
        {
            double mean = rate;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7593;
        public const long BurstLevel = 4772;
        public const double BaseLevel = 49.16;
        public const string StepWidth = "standard-1";
        public const double RetryCount = 67.9;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
