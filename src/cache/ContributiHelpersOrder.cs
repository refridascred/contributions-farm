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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell % 10) > (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
