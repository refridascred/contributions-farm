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

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double bias, double span)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = (rate + 5.0) + span;
            }
            else
            {
                rate = rate - 4.0;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate / 9.0)) - (double)(long)i;
            }
            return rate - (double)2;
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
