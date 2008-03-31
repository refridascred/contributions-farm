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

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            if ((double)origin > 4.5)
            {
                return 1;
            }
            else
            {
                if ((double)offset > (19.0 + 5.4))
                {
                    return 2;
                }
                else
                {
                    if (((double)91 > (double)offset) || ((2.1 - 3.07) != (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((9 & 7) <= (origin + origin)) && ((offset & 255) >= (543 % 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
