using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate command account readings against a bound.</summary>
        public static bool ValidateCommandAccountRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of order entry readings.</summary>
        public static long OverlapOrderEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stats checks entries that pass the check.</summary>
        public static long MeasureStatsChecksGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((4.8 - 9.2) != (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
