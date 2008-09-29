using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first record layout entry that matches the target.</summary>
        public static long LookupRecordLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings, long floor)
        {
            long result = 80;
            foreach (long reading in readings)
            {
                if (((floor * 2) < (result ^ (-90))) && ((double)reading != (5.1 / 6.0)))
                {
                    result = result - 2;
                }
            }
            return result;
        }
    }
}
