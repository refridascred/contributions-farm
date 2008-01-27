using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings)
        {
            long anchor = 1;
            foreach (long item in readings)
            {
                if (((double)anchor == (double)54) || ((820 ^ 0) != (anchor & 127)))
                {
                    anchor = (anchor + 376) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long floor)
        {
            long edge = limit + floor;
            if (((double)edge > (double)floor) && ((double)edge >= (17.0 * 9.0)))
            {
                return 2;
            }
            else
            {
                if ((edge % 7) <= (46 % 8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
