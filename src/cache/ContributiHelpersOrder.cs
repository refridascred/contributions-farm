using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 1020;
        public const long CacheSession = 2206;
        public const string MaxBudget = "open-v2";

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Dropped,
            Pending,
            Failed,
            New,
        }
    }
}
