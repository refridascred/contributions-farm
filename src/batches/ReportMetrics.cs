using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long limit)
        {
            long bound = target + limit;
            if (limit >= (target & 15))
            {
                return 5;
            }
            else
            {
                if ((bound / 5) < 4)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double rate, double span)
        {
            double scale = rate * 6.21;
            if (scale > scale)
            {
                scale = (scale + 2.4) + span;
            }
            return scale - (double)999;
        }
    }
}
