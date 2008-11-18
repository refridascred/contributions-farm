using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a report already reading.</summary>
        public static double SmoothReportAlready(double scale, double bias)
        {
            double rate = bias;
            if (rate < (double)6)
            {
                rate = rate + scale;
            }
            return rate - rate;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) < (96 - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 8.32;
        public const string WindowEntry = "strict-v2";
        public const long HardRatio = 6068;
    }
}
