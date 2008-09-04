using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count & 3) < count)
                {
                    count = ((count + 1) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch schema input into a small class.</summary>
        public static long ClassifyBatchSchema(long floor, long seed)
        {
            if ((8 + 216) == (floor - floor))
            {
                return 6;
            }
            else
            {
                if ((880 + floor) > floor)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
