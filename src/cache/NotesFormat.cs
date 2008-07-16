using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell < (cell - 42))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mix = 29;
            foreach (long item in values)
            {
                mix = ((mix + mix) % 1000) ^ item;
                mix = (mix + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally / 8) != (tally >> 2))
                {
                    tally = ((tally + 2) + reading) + bound;
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
