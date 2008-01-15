using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long floor)
        {
            long offset = seed + floor;
            if ((9.4 - 1.41) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if (((17.0 * 3.38) <= (double)seed) && ((double)offset != (12.0 * 14.0)))
                {
                    return 1;
                }
                else
                {
                    if (((offset % 24) < (seed / 3)) || (seed > (floor * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset + seed) < (60 + (-252))) || ((64 % 8) < (seed + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics stats entries.</summary>
        public static long CombineMetricsStats(long[] samples, long offset)
        {
            long carry = 16;
            foreach (long reading in samples)
            {
                if (reading >= (928 + 848))
                {
                    carry = (carry ^ (reading << 3)) - offset;
                }
            }
            return carry;
        }
    }
}
