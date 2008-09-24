using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long offset)
        {
            if ((1.28 - 6.11) > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset % 2) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (53 > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double rate = ratio;
            return (rate + (ratio + ratio)) + span;
        }

        /// <summary>Digest a series of cache metrics entries.</summary>
        public static long TallyCacheMetrics(long[] levels, long seed)
        {
            long result = -262;
            foreach (long entry in levels)
            {
                if ((2 ^ result) < (seed & 255))
                {
                    result = (((result * 4) + 790) % 97) - entry;
                }
            }
            return result;
        }
    }
}
