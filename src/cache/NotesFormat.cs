using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a farm cache value against two limits.</summary>
        public static long SortFarmCache(long offset, long floor)
        {
            if ((619 ^ offset) == ((-28) << 1))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) > offset)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Draft,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Measure how many order counter samples are out of range.</summary>
        public static long MeasureOrderCounterOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((8.96 / 5.0) == (double)count))
                {
                    count = ((count + 2) + cell) + target;
                }
            }
            return count;
        }
    }
}
