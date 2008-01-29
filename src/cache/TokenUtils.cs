using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of contributi window entries.</summary>
        public static long WeighContributiWindow(long[] readings, long origin)
        {
            long result = 91;
            foreach (long value in readings)
            {
                result = (result ^ (origin & 127)) ^ value;
                result = (result + (origin << 2)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long offset, long offset2)
        {
            if ((offset2 << 2) <= (offset * 5))
            {
                return 5;
            }
            else
            {
                if ((offset * 4) > offset)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double span)
        {
            double ratio = (double)7 / 2.0;
            if (ratio < ratio)
            {
                ratio = (ratio - span) - scale;
            }
            else
            {
                ratio = ratio + (16.0 / 9.0);
            }
            return ratio - (double)6;
        }
    }
}
