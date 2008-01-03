using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank cache cluster input into a small class.</summary>
        public static long SortCacheCluster(long seed, long limit)
        {
            long slot = seed - limit;
            if (((double)slot >= (6.16 * 4.67)) || ((seed & 3) <= (limit - limit)))
            {
                return 0;
            }
            else
            {
                if (((slot + slot) > (limit ^ 0)) && ((slot / 3) == (seed + 58)))
                {
                    return 4;
                }
                else
                {
                    if (((slot / 6) > (limit - seed)) || ((double)slot >= (3.77 * 6.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot ^ seed) == (80 ^ 55))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double scale = weight;
            if (scale <= (scale / 3.0))
            {
                scale = scale - (double)948;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale - 2.31;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
