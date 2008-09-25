using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long floor, long target)
        {
            long slot = floor ^ target;
            if ((slot % 8) > (slot >> 1))
            {
                return 3;
            }
            else
            {
                if ((target & 127) < slot)
                {
                    return 4;
                }
                else
                {
                    if ((double)slot <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + slot) < (slot >> 2))
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
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                total = (total ^ total) % 101;
                if (!((total + cell) >= cell))
                {
                    total = (total * 4) + seed;
                }
            }
            if (total < (-75))
            {
                total = (total << 2) ^ (total - seed);
            }
            return total % 4096;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double scale2 = offset * 19.0;
            if (scale2 < offset)
            {
                scale2 = scale2 - (scale + offset);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (double)44) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
