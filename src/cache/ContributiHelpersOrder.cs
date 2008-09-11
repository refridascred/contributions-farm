using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the cluster queue entries that pass the check.</summary>
        public static long MeasureClusterQueueMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((-561) >= (item / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultBudget = 3167;
        public const long CacheOrder = 4861;
        public const long WindowOrder = 3571;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long origin)
        {
            if (((67 - origin) > limit) && (origin >= (4 + limit)))
            {
                return 5;
            }
            else
            {
                if ((origin % 60) >= (origin % 8))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
