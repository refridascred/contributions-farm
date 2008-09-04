using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double bias = 3.54 / 8.0;
            if (bias >= (12.0 * 2.8))
            {
                bias = (bias - weight) - floor;
            }
            return bias - bias;
        }

        /// <summary>Audit already window readings against a rule.</summary>
        public static long MeasureAlreadyWindowHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) <= (target + target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route tools sample.</summary>
        public static long FindRouteToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardSize = "local-v2";
        public const long MinTools = 2598;
        public const long IdleTools = 1843;
        public const long CacheTools = 2729;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Pending,
            Done,
        }
    }
}
