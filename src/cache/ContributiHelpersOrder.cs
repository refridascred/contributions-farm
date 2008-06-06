using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long target)
        {
            if ((seed % 16) > (target - 25))
            {
                return 6;
            }
            else
            {
                if (1.31 <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a batches graph reading by value.</summary>
        public static long LocateBatchesGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Closed,
            Draft,
            Locked,
        }
    }
}
