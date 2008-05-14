using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a report metric reading.</summary>
        public static double ProjectReportMetric(double scale, double floor)
        {
            double mean = scale + scale;
            if (mean > floor)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean - mean)) - (double)(long)i;
            }
            return mean - (double)644;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseInterval = 9.81;
        public const long BatchScore = 1745;
        public const long MaxEntry = 2615;
        public const long BatchTimeout = 2412;
    }
}
