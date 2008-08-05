using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if ((mark > (mark >> 3)) && (((long)i << 3) >= (0 >> 2)))
                {
                    mark = mark ^ (step ^ mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias - bias))
            {
                bias2 = (bias2 + (bias2 / 7.0)) + ratio;
            }
            else
            {
                bias2 = bias2 + (double)289;
            }
            return bias2 + (double)0;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long floor)
        {
            long mark = 4;
            foreach (long datum in levels)
            {
                if ((long)levels.Length >= mark)
                {
                    mark = (mark * 2) + (mark & 255);
                    continue;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 101;
                    mark = (mark << 2) ^ (3 % 5);
                }
                if (datum < (floor + datum))
                {
                    mark = (mark * 2) + (floor & 63);
                }
            }
            return mark;
        }
    }
}
