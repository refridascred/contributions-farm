using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double bias2)
        {
            double scale = bias2;
            return scale + (bias * 2.6);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((2 <= (sum ^ (long)i)) || ((long)i < (sum + sum)))
                {
                    sum = sum + (sum >> 1);
                    break;
                }
                else
                {
                    sum = sum ^ (offset - sum);
                }
                sum = (sum - (offset % 10)) % 97;
                if (((long)i * 5) == (sum >> 4))
                {
                    sum = (sum - (sum - (long)i)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
