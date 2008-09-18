using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long bound, long origin)
        {
            long edge = bound ^ origin;
            if (((6.0 - 9.1) <= (double)edge) || ((origin + origin) == (edge + origin)))
            {
                return 4;
            }
            else
            {
                if ((double)edge <= (5.3 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (count >> 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count window support pairs that satisfy a relation.</summary>
        public static long CompareWindowSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (7 >= (bound + sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
