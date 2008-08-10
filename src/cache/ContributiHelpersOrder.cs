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

        /// <summary>Compare every pair of already counter readings.</summary>
        public static long PairAlreadyCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
