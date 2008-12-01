using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long seed)
        {
            long slot = offset ^ seed;
            if (seed <= (8 >> 5))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) > (seed / 4))
                {
                    return 2;
                }
                else
                {
                    if (!((double)slot > (5.21 * 12.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (slot > (seed - 79))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinInterval = 62.06;
        public const long CacheScore = 4314;
        public const long MinDepth = 6980;

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = (gain - bias) + bias2;
            }
            else
            {
                gain = gain + 0.6;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (bias - gain);
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
