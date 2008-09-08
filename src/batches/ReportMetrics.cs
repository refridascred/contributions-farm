using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a channel metric sample.</summary>
        public static long FindChannelMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (double)53) - (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] series, long origin)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if ((double)origin != (double)49)
                {
                    sum = ((sum + sum) % 255) ^ entry;
                }
            }
            return sum % 65521;
        }
    }
}
