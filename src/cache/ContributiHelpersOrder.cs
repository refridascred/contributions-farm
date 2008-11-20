using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor ^ 3) <= 65)
                {
                    mark = (mark - (mark / 4)) % 1000;
                }
                else
                {
                    mark = (mark * 3) + (5 + mark);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + item) != (item - (-527)))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Count entry stats pairs that satisfy a relation.</summary>
        public static long OverlapEntryStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
