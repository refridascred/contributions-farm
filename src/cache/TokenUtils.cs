using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long step, long bound)
        {
            if (((step + step) != (bound ^ bound)) || ((double)step > 8.9))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= bound)
                {
                    return 1;
                }
                else
                {
                    if (14 >= (49 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
