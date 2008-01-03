using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 5) >= (entry + (-222)))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long result = 1;
            foreach (long item in levels)
            {
                if (((item << 3) == (7 - item)) && ((item * 2) >= (result - result)))
                {
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (item ^ result)) % 4096;
                }
                result = (result + (result * 4)) % 4096;
            }
            if (result < 1)
            {
                result = ((result << 2) ^ 227) % 255;
            }
            return result;
        }
    }
}
