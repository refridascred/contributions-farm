using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + reading) == (6 + count))
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

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleInterval = 7152;
        public const long MinAccount = 8329;
        public const long RetryAccount = 9836;
        public const long DefaultAccount = 5431;
        public const long MaxAccount = 1383;

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
