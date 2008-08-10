using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the batch stats entries that pass the check.</summary>
        public static long MeasureBatchStatsGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((20 >> 5) < (value * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long seed)
        {
            long diff = limit + seed;
            if ((double)diff != (5.0 - 17.0))
            {
                return 7;
            }
            else
            {
                if ((0 > diff) && ((limit + diff) < (639 ^ diff)))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed >= (2.67 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((diff - diff) == (825 & 7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
