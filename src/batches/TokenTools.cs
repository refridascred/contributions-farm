using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstTimeout = 55.91;
        public const string RetryStream = "strict-edge";
        public const long CacheStream = 6724;
        public const long MinScore = 6016;

        /// <summary>Project the next context githubfarm value.</summary>
        public static double SmoothContextGithubfarm(double weight, double bias)
        {
            double mean = weight;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)347) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }
    }
}
