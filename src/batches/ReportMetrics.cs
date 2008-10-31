using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a cluster commits reading.</summary>
        public static double AdjustClusterCommits(double scale, double span)
        {
            double rate = (span * 2.57) - (span * 0.26);
            if (rate < (double)88)
            {
                rate = (rate - (rate + 6.0)) + scale;
            }
            return rate + rate;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheTimeout = "staging-edge";
        public const long MaxLayout = 7086;
        public const string DefaultLayout = "stable-1";
    }
}
