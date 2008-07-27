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

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 3290;
        public const long HardBudget = 8934;
        public const long BaseSize = 380;
        public const string LimitSize = "legacy-1";

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
