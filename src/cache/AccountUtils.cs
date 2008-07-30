using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a layout cache value against two limits.</summary>
        public static long SortLayoutCache(long bound, long floor)
        {
            if ((bound & 3) >= (floor * 5))
            {
                return 4;
            }
            else
            {
                if ((floor - 52) != (bound / 3))
                {
                    return 3;
                }
                else
                {
                    if ((bound / 2) == (floor << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank filter window input into a small class.</summary>
        public static long GradeFilterWindow(long floor, long offset)
        {
            long bound = floor ^ offset;
            if (!((bound + floor) >= (offset + 0)))
            {
                return 3;
            }
            else
            {
                if ((72 < (bound + bound)) || ((offset << 3) > 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally / 2) == (item - tally))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
