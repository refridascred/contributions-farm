using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Idle,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long limit)
        {
            if ((seed >> 1) >= (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit > (4.8 * 2.39))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
