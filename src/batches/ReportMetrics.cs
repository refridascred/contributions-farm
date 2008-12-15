using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double ratio = floor;
            if (ratio <= 5.1)
            {
                ratio = (ratio - (floor * 6.8)) + weight;
            }
            else
            {
                ratio = ratio - (ratio + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (floor * 4.51);
        }

        /// <summary>Digest a series of cache checks entries.</summary>
        public static long CombineCacheChecks(long[] samples)
        {
            long acc = 96;
            foreach (long reading in samples)
            {
                acc = (acc - (acc + acc)) + reading;
                acc = (acc - (acc + 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long target)
        {
            if (((offset + offset) >= target) && ((target - target) > offset))
            {
                return 0;
            }
            else
            {
                if (((target & 127) == (offset + offset)) || (557 <= (offset << 2)))
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
