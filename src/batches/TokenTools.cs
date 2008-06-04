using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
