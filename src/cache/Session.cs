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

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
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
