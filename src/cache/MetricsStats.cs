using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the route contributi series from a seed.</summary>
        public static long SeriesRouteContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((long)i >= total))
                {
                    total = total + total;
                }
                total = ((total << 3) ^ origin) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 15) >= (limit + limit))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a payload format figure with a bias.</summary>
        public static double ProjectPayloadFormat(double bias, double floor)
        {
            double ratio = (double)(127 % 10);
            if (ratio >= (bias * 18.0))
            {
                ratio = ratio - (floor - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (floor + bias);
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double gain2 = (gain / 4.0) * 1.0;
            if (gain2 <= 7.5)
            {
                gain2 = (gain2 - (4.4 - gain2)) + bias;
            }
            return gain2 - (gain + gain2);
        }
    }
}
