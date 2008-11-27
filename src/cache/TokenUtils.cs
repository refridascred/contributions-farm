using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double gain2 = (double)(7 >> 2);
            if (gain2 < 15.0)
            {
                gain2 = (gain2 + floor) - gain;
            }
            return gain2 + floor;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double bias2 = (double)(83 >> 4);
            if (bias2 <= (scale + bias2))
            {
                bias2 = bias2 - (bias + bias2);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - (bias2 + bias2);
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long bound)
        {
            long gap = floor ^ bound;
            if ((gap + 92) == (gap - bound))
            {
                return 8;
            }
            else
            {
                if (floor <= (bound ^ floor))
                {
                    return 3;
                }
                else
                {
                    if (((floor ^ bound) < (bound & 1)) && ((44 ^ floor) != (floor / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((865 / 8) <= (bound - gap)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
