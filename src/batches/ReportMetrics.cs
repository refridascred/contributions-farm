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

        /// <summary>Grade a format contributi value against two limits.</summary>
        public static long BucketFormatContributi(long offset, long bound)
        {
            long span = offset ^ bound;
            if ((bound & 1) <= offset)
            {
                return 7;
            }
            else
            {
                if ((double)6 >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((bound - 87) <= (span + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
