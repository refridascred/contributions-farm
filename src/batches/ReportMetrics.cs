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

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double bias = (double)3 / 2.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - bias) + (double)(long)i) + ratio) + offset;
            }
            return bias - 8.0;
        }
    }
}
