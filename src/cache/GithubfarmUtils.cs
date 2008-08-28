using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 5489;
        public const string StepAccount = "staging";
        public const long HardAccount = 4282;
        public const long SoftCount = 7731;

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
