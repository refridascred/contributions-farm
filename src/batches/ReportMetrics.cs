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

        /// <summary>Classify a command commits pair into a bucket.</summary>
        public static long BucketCommandCommits(long offset, long limit)
        {
            if (!((396 & 255) < (limit % 3)))
            {
                return 6;
            }
            else
            {
                if (((double)limit < 20.0) && ((offset + offset) < (offset >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 7687;
        public const long MaxContributi = 2494;
        public const string IdleContributi = "staging-1";
        public const double SoftContributi = 5.63;
    }
}
