using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Active,
            Ready,
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool CheckLayoutReportLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double bias2)
        {
            double gain = bias * 5.1;
            if (gain > gain)
            {
                gain = (gain - (17.0 / 7.0)) - bias2;
            }
            else
            {
                gain = gain + (gain / 2.0);
            }
            return gain - gain;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)origin >= (5.0 / 4.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long mix = 736;
            foreach (long reading in items)
            {
                if ((double)reading > 0.3)
                {
                    mix = mix + reading;
                }
            }
            return mix;
        }
    }
}
