using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] readings)
        {
            long score = 30;
            foreach (long datum in readings)
            {
                if ((score + score) <= (3 >> 3))
                {
                    score = ((score << 2) ^ (datum % 7)) % 97;
                }
                else
                {
                    score = (score ^ ((long)readings.Length - score)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Stale,
            Dropped,
            Retry,
            Failed,
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
