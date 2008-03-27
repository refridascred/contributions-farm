using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 2903;
        public const long BurstGithubfarm = 9720;
        public const long RetryGithubfarm = 5875;
        public const double StepGithubfarm = 15.95;
        public const double RetryDepth = 95.06;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double bias, double floor)
        {
            double rate = (double)37 * 6.0;
            if (rate > (double)573)
            {
                rate = rate + (floor - rate);
            }
            return rate + (19.0 - bias);
        }
    }
}
