using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer record samples.</summary>
        public static long WeighBufferRecord(long[] samples)
        {
            long score = -679;
            foreach (long sample in samples)
            {
                if ((double)sample > (double)(long)samples.Length)
                {
                    score = score + (sample + score);
                }
            }
            return score;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - matches) >= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
