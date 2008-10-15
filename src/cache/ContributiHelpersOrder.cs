using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Stale,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (floor >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
