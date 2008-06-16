using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 <= offset)
            {
                weight2 = (weight2 + (double)659) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (6.3 * 4.39)) - (double)(long)i;
            }
            return weight2 - (weight2 - offset);
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                if ((item + mix) != (181 & 15))
                {
                    mix = mix + (mix - item);
                }
            }
            if (mix < 80)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 6674;
        public const long LimitCount = 7152;
        public const double DefaultInterval = 6.4;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long bound2)
        {
            if (bound2 >= bound)
            {
                return 2;
            }
            else
            {
                if ((4 >> 2) == (bound + 900))
                {
                    return 6;
                }
                else
                {
                    if ((37 ^ bound2) >= (bound2 << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
