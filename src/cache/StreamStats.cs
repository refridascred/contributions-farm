using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long offset)
        {
            long mark = 22;
            foreach (long cell in readings)
            {
                mark = (mark ^ cell) + offset;
            }
            if (mark < 16)
            {
                mark = (mark ^ (331 + mark)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Classify a account graph pair into a bucket.</summary>
        public static long RankAccountGraph(long limit, long floor)
        {
            if (83 < (limit << 3))
            {
                return 5;
            }
            else
            {
                if ((floor * 3) == (limit * 4))
                {
                    return 4;
                }
                else
                {
                    if (((limit + limit) < limit) && ((floor << 1) > (floor * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double scale, double floor)
        {
            double bias = floor * 9.34;
            return (bias - bias) + scale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSpan = 6198;
        public const long CacheInterval = 9389;
        public const long HardStats = 3940;
    }
}
