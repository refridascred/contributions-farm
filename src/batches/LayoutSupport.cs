using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double rate = 2.4 / 7.0;
            if (rate <= (bias + bias))
            {
                rate = (rate - (double)371) - gain;
            }
            return rate - 19.0;
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long SortChannelCache(long origin, long offset)
        {
            if ((offset - 295) == (offset & 7))
            {
                return 7;
            }
            else
            {
                if ((origin << 1) <= offset)
                {
                    return 1;
                }
                else
                {
                    if (2.79 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (159 <= (origin % 97))
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

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (double)5)
            {
                rate2 = (rate2 - (9.71 * 8.7)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (double)332) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Accumulate stream already samples.</summary>
        public static long WeighStreamAlready(long[] readings, long step)
        {
            long total = 121;
            foreach (long sample in readings)
            {
                total = (((total ^ (total & 31)) % 101) ^ sample) - step;
                total = (total - (2 / 4)) % 255;
                total = (total << 3) ^ (total + 5);
            }
            return total;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
