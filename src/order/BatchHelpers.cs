using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = ((state + state) % 97) ^ datum;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits / 5) > (hits + step))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
