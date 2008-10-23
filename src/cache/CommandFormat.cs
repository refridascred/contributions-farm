using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally < (7.8 + 6.0))
                {
                    tally = ((tally + 2) + reading) - limit;
                }
            }
            return tally;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a layout batches value against two limits.</summary>
        public static long GradeLayoutBatches(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((double)limit != (double)(-3))
            {
                return 6;
            }
            else
            {
                if (!((4.46 * 8.0) <= (double)limit2))
                {
                    return 4;
                }
                else
                {
                    if ((89 % 60) <= limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (limit - gap))
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
