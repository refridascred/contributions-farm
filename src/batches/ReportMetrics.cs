using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a githubfarm cluster figure with a bias.</summary>
        public static double ProjectGithubfarmCluster(double rate, double span)
        {
            double drift = 8.73;
            if (drift <= (1.3 + rate))
            {
                drift = (drift + (rate - drift)) + span;
            }
            else
            {
                drift = drift - 20.0;
            }
            return drift - rate;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 1855;
        public const long StepCommits = 7678;
        public const string CacheCommits = "stable-1";
        public const long HardDepth = 824;
        public const long LimitScore = 4576;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Pending,
            Closed,
            Failed,
            Dropped,
        }
    }
}
