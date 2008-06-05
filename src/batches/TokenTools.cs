using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double gain = (floor - 5.8) + (double)81;
            if (gain >= (floor / 4.0))
            {
                gain = gain + 1.13;
            }
            else
            {
                gain = gain + (ratio + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (2.1 / 9.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Digest a series of stats cache entries.</summary>
        public static long TallyStatsCache(long[] items)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                anchor = (((anchor * 5) + (anchor ^ anchor)) % 101) - datum;
                anchor = (anchor * 3) + 59;
            }
            return anchor;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark + offset) - (long)i2;
                }
                mark = (mark ^ (offset & 1)) % 4096;
                mark = mark + (127 << 3);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
