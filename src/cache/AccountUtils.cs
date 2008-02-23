using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many filter farm samples are out of range.</summary>
        public static long CountFilterFarmOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((0.63 - 5.05) > (double)step))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (5.8 + 0.2))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 2) ^ state;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
