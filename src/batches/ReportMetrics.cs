using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next report session value.</summary>
        public static double SmoothReportSession(double bias, double bias2)
        {
            double mean = bias;
            if (mean < (bias2 * 5.3))
            {
                mean = mean - (double)(-703);
            }
            return mean - (mean * 8.4);
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a profile window reading.</summary>
        public static double SmoothProfileWindow(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + 1.06) + (double)(long)i) + span;
            }
            return rate + 8.1;
        }
    }
}
