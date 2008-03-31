using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "legacy-v2";
        public const double BaseCounter = 80.5;
        public const long BatchTimeout = 8404;
        public const long SoftCounter = 5763;
        public const long SoftTimeout = 1519;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
