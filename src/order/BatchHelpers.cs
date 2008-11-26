using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Retry,
            Active,
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
