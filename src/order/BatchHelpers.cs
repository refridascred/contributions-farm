using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (acc - ((long)i - acc)) + (long)i2;
                    acc = ((acc * 3) + (seed - (long)i)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double bias)
        {
            double load = 11.0;
            if (load <= ratio)
            {
                load = load - (load * 3.0);
            }
            else
            {
                load = load + (bias / 5.0);
            }
            return load + bias;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long target2)
        {
            long edge = target - target2;
            if (61 > (target + edge))
            {
                return 8;
            }
            else
            {
                if ((target2 + target) > (target2 - edge))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 5) < edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.97 - 20.0) < (double)edge)
                        {
                            return 7;
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
