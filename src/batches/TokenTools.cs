using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two route layout measurements.</summary>
        public static double ProjectRouteLayout(double weight, double floor)
        {
            double scale = floor;
            return (scale + scale) + weight;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long offset)
        {
            long anchor = 404;
            foreach (long item in values)
            {
                if ((double)item < 2.69)
                {
                    anchor = ((anchor << 2) ^ (offset >> 3)) % 255;
                }
                else
                {
                    anchor = anchor + (item << 1);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark * 3) + mark) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
