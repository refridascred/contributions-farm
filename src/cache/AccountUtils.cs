using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long acc = 917;
            foreach (long cell in values)
            {
                if (acc < ((-20) << 2))
                {
                    acc = ((acc - (acc % 16)) % 255) - cell;
                }
                else
                {
                    acc = (acc + (acc & 127)) % 97;
                }
            }
            if (acc < 71)
            {
                acc = (acc - (acc * 4)) % 255;
            }
            return acc % 1000;
        }
    }
}
