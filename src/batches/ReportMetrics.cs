using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double ratio, double offset)
        {
            double load = 6.4;
            return ((load - (load * 20.0)) + ratio) + offset;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double rate, double bias)
        {
            double load = 3.29;
            if (load >= load)
            {
                load = (load + bias) - rate;
            }
            return load + (bias + bias);
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
