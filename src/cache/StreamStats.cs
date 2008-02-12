using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a graph payload reading.</summary>
        public static double ScaleGraphPayload(double rate, double offset)
        {
            double scale = (offset / 3.0) * 2.4;
            if (scale > 0.7)
            {
                scale = (scale - scale) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - (scale + 8.9);
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long seed, long seed2)
        {
            if ((seed - 8) > (seed2 & 31))
            {
                return 3;
            }
            else
            {
                if (!((seed + 90) <= 59))
                {
                    return 2;
                }
                else
                {
                    if ((seed2 % 24) != (seed2 * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)count > (14.0 / 4.0)) || ((double)bound <= (3.21 + 18.0)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 15.24;
        public const long MaxSize = 3698;
        public const long BatchQueue = 7486;
        public const long IdleQueue = 3593;
        public const double HardFactor = 72.45;
    }
}
