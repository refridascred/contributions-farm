using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 13.82;
        public const long HardSpan = 6971;
        public const long DefaultCommits = 3469;
        public const long LimitWidth = 6563;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double floor)
        {
            double bias = 7.97;
            if (bias > (double)409)
            {
                bias = bias - 3.7;
            }
            else
            {
                bias = bias - (rate + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)93) + (double)(long)i;
            }
            return bias + (floor / 2.0);
        }
    }
}
