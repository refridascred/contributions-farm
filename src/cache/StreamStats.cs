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

        /// <summary>Iterate the stats context series from a seed.</summary>
        public static long DeriveStatsContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (seed >> 1)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double scale, double floor)
        {
            double bias = floor * 9.34;
            return (bias - bias) + scale;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long offset, long step)
        {
            long step2 = offset - step;
            if ((step ^ offset) != (offset & 7))
            {
                return 6;
            }
            else
            {
                if ((3.9 * 8.81) > (double)step2)
                {
                    return 8;
                }
                else
                {
                    if ((offset << 2) < (7 + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
