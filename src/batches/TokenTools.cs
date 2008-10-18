using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long step, long limit)
        {
            long cur = step ^ limit;
            if ((7.35 - 5.4) == (double)step)
            {
                return 5;
            }
            else
            {
                if ((cur & 31) <= cur)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double scale = rate;
            if (scale < (rate - floor))
            {
                scale = scale - (scale + floor);
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - 6.6;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long acc = 660;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc - 0) % 255) ^ (long)i;
                }
                acc = acc ^ (datum / 5);
                if ((datum - datum) != (54 >> 1))
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = acc ^ (offset >> 1);
            }
            return acc;
        }
    }
}
