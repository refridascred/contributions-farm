using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor order value against two limits.</summary>
        public static long GradeEditorOrder(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((floor * 2) > offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset == (10.0 * 8.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor - offset) <= (floor - gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Closed,
            Pending,
        }
    }
}
