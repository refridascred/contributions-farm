using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long offset)
        {
            if (((double)floor < (12.0 + 3.0)) || ((floor * 5) == (floor - floor)))
            {
                return 3;
            }
            else
            {
                if ((floor ^ offset) < offset)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
