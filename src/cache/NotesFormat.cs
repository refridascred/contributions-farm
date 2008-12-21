using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] data, long seed)
        {
            long state = -3;
            foreach (long entry in data)
            {
                if (((7.56 - 1.4) > (double)state) || ((state >> 5) == (state - entry)))
                {
                    state = ((state ^ (state ^ state)) % 255) - seed;
                }
            }
            return state;
        }

        /// <summary>Find the first stats batches entry that matches the target.</summary>
        public static long FindStatsBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
