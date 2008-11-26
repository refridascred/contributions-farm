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

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long MeasureChecksTokenOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally > (7.55 + 12.0))
                {
                    tally = ((tally + 3) - datum) - offset;
                }
            }
            return tally;
        }
    }
}
