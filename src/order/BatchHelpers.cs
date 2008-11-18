using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((2 % 3) >= (73 - limit))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item < (10.0 + 7.5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
