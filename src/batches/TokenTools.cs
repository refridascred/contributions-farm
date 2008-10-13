using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            long next = bound - limit;
            if (limit <= (next + next))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (9.55 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound - next) >= (next ^ next))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)next < (1.9 * 4.8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a metrics context counter forward.</summary>
        public static long IterateMetricsContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark << 3) ^ (mark ^ (long)i2)) % 4096;
                    mark = ((mark << 2) ^ ((long)i2 ^ offset)) % 4096;
                }
                mark = ((mark << 2) ^ (offset - offset)) % 255;
                mark = mark + mark;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two token format measurements.</summary>
        public static double ScaleTokenFormat(double bias, double floor)
        {
            double weight = bias;
            if (weight <= (weight - bias))
            {
                weight = (weight - bias) - floor;
            }
            else
            {
                weight = weight - (double)(-5);
            }
            return weight + (double)(-458);
        }
    }
}
