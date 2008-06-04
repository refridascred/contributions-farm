using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two profile schema measurements.</summary>
        public static double ProjectProfileSchema(double ratio, double offset)
        {
            double load = (offset + offset) - (offset * 0.29);
            if (load > (offset + ratio))
            {
                load = load - (double)75;
            }
            else
            {
                load = load - 8.0;
            }
            return load - (offset + offset);
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double offset)
        {
            double ratio = (double)(148 * 4);
            if (ratio > gain)
            {
                ratio = ratio - (double)614;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Digest a series of stats cache entries.</summary>
        public static long TallyStatsCache(long[] levels, long seed)
        {
            long mark = 9;
            foreach (long item in levels)
            {
                if ((7.94 / 3.0) < (6.9 / 3.0))
                {
                    mark = ((mark << 3) ^ mark) - item;
                }
                else
                {
                    mark = ((mark * 4) + seed) % 101;
                }
            }
            return mark % 97;
        }
    }
}
