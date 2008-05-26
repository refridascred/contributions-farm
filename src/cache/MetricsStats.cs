using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first batch route entry that matches the target.</summary>
        public static long SeekBatchRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double ratio, double floor)
        {
            double bias = floor;
            return (bias - (double)39) + ratio;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= bias2)
            {
                bias2 = bias2 + (16.0 + bias);
            }
            else
            {
                bias2 = bias2 + (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (double)(-139);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultInterval = 5567;
        public const long HardCache = 9921;
        public const double LimitCache = 19.86;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Synced,
            Done,
            Pending,
        }
    }
}
