using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double weight = (double)(6 / 9);
            if (weight > (13.0 / 5.0))
            {
                weight = ((weight + (double)4) - gain) + bias;
            }
            return weight + 3.0;
        }

        /// <summary>Measure how many filter payload samples are out of range.</summary>
        public static long CountFilterPayloadOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (origin > (343 - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double load = (double)34;
            return (load - rate) + offset;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 14.41;
        public const long BatchScore = 7036;
        public const long BaseWidth = 2940;

        /// <summary>Rank route stream input into a small class.</summary>
        public static long GradeRouteStream(long target, long floor)
        {
            if (target <= (target * 3))
            {
                return 4;
            }
            else
            {
                if (floor <= (floor << 1))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
