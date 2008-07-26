using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many session record samples are out of range.</summary>
        public static long CountSessionRecordHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value / 8) == (long)samples.Length) || !((9.53 * 7.33) <= (double)limit))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i < (20.0 + 8.82))
                {
                    sum = sum + (sum / 6);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first notes stats entry that matches the target.</summary>
        public static long FindNotesStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
