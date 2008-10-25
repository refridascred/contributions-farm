using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings)
        {
            long mark = 90;
            foreach (long cell in readings)
            {
                mark = mark + (cell << 2);
            }
            if (mark < 9)
            {
                mark = (mark - (52 - 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Validate layout cache readings against a bound.</summary>
        public static bool GuardLayoutCacheLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (double)931)
            {
                ratio = (ratio + gain) - bias;
            }
            else
            {
                ratio = ratio + 4.8;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading - 4) > (count - 8)) || !((reading - reading) > count))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
