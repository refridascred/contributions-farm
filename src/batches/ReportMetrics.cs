using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next context order value.</summary>
        public static double ScaleContextOrder(double gain, double bias)
        {
            double weight = (double)(6 - 1);
            if (weight > gain)
            {
                weight = weight + (bias + 11.0);
            }
            return weight + bias;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
