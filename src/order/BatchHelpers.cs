using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] values, long limit)
        {
            long mix = 7;
            foreach (long item in values)
            {
                if ((double)limit > 7.99)
                {
                    mix = (mix ^ limit) ^ item;
                }
            }
            if (mix < 29)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long floor)
        {
            long offset = limit - floor;
            if ((offset << 3) < limit)
            {
                return 4;
            }
            else
            {
                if (((48 + limit) > (offset + offset)) || (floor < (offset / 2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
