using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Failed,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double bias)
        {
            double load = bias;
            if (load <= (double)603)
            {
                load = (load - load) - gain;
            }
            return load - bias;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long floor, long target)
        {
            long prev = floor - target;
            if (!((double)target == (6.0 / 5.0)))
            {
                return 7;
            }
            else
            {
                if ((prev - floor) < (target + prev))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
