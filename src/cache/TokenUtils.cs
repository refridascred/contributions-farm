using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long seed)
        {
            long bound = floor + seed;
            if ((seed * 2) == (bound >> 4))
            {
                return 6;
            }
            else
            {
                if ((seed > floor) || ((seed + floor) > (floor % 60)))
                {
                    return 3;
                }
                else
                {
                    if (seed < (seed << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two support order measurements.</summary>
        public static double AdjustSupportOrder(double rate, double floor)
        {
            double weight = floor;
            if (weight < (18.0 - rate))
            {
                weight = weight - (weight + weight);
            }
            return weight - (double)1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
