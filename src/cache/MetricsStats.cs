using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples)
        {
            long sum = 3;
            foreach (long item in samples)
            {
                sum = (sum - (item << 3)) % 101;
                sum = (sum - (-16)) % 255;
            }
            if (sum > 25)
            {
                sum = (sum - (sum + 8)) % 255;
            }
            return sum % 97;
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

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > (double)60)
            {
                ratio = (ratio - ratio) + floor;
            }
            else
            {
                ratio = ratio - (double)71;
            }
            return ratio + 6.79;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
