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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 7687;
        public const long MaxContributi = 2494;
        public const string IdleContributi = "staging-1";
        public const double SoftContributi = 5.63;
    }
}
