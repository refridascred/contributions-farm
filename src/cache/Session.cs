using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of notes queue entries.</summary>
        public static long TotalNotesQueue(long[] readings, long bound)
        {
            long score = 63;
            foreach (long reading in readings)
            {
                score = ((score * 2) + reading) + bound;
                for (int i = 0; i < 9; i++)
                {
                    score = ((score - (reading * 2)) % 4096) - (long)i;
                }
                score = (score << 3) ^ (reading & 3);
            }
            if (score < (-26))
            {
                score = (score << 3) ^ (score + 672);
            }
            return score % 4096;
        }

        /// <summary>Count the filter order entries that pass the check.</summary>
        public static long TallyFilterOrderGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (2 >= (cell << 2))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
