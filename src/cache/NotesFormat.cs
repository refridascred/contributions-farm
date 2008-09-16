using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit counter queue readings against a rule.</summary>
        public static long MeasureCounterQueueMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count ^ count) >= (value * 5)) || (((long)values.Length << 3) < (value + 34))) || ((double)value <= (3.5 - 4.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((4.0 / 5.0) >= (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long TallyBatchChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - value) < tally)
                {
                    tally = tally + 1;
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
