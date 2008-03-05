using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] series, long offset)
        {
            long total = 97;
            foreach (long reading in series)
            {
                total = ((total + (total ^ 684)) % 65521) ^ reading;
            }
            if (total < 235)
            {
                total = (total << 3) ^ offset;
            }
            return total % 4096;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long floor)
        {
            long edge = seed - floor;
            if ((60 & 63) >= (edge / 2))
            {
                return 7;
            }
            else
            {
                if (((edge % 60) <= 288) && ((0.03 + 3.12) < (double)edge))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
