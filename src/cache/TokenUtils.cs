using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long origin, long limit)
        {
            if (((limit - origin) == (limit - limit)) && ((origin >> 4) == ((-3) * 3)))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) < (origin & 31))
                {
                    return 3;
                }
                else
                {
                    if (!((double)limit < 3.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double scale, double offset)
        {
            double gain = (scale / 9.0) / 9.0;
            if (gain < (double)21)
            {
                gain = gain - offset;
            }
            return gain - (double)825;
        }
    }
}
