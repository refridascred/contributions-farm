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

        /// <summary>Roll a context order counter forward.</summary>
        public static long RollContextOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (sum << 1)) % 255;
                sum = (sum ^ ((long)i / 5)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
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
