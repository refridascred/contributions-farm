using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format schema value against two limits.</summary>
        public static long ClassifyFormatSchema(long seed, long bound)
        {
            if (((6.48 / 3.0) <= (double)seed) && ((seed % 97) != (seed + 8)))
            {
                return 8;
            }
            else
            {
                if (seed <= (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound + seed) <= (seed >> 2)) || ((84 >> 1) <= (164 ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + (double)33;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSize = 418;
        public const long BurstFormat = 270;
        public const double BatchScore = 6.46;
        public const long BurstCount = 3831;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)limit < (double)mark)
                {
                    mark = ((mark * 5) + (limit << 2)) % 255;
                }
                mark = ((mark << 3) ^ (mark >> 3)) % 4096;
                mark = (mark - limit) % 255;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
