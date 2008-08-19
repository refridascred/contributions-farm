using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many report support samples are out of range.</summary>
        public static long AuditReportSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (7.75 < (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double gain = weight / 4.0;
            if (gain <= weight)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - bias;
            }
            return gain - gain;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
