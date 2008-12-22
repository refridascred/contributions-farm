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

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheWidth = 2847;
        public const string WindowBudget = "stable";
        public const long MaxCommits = 1286;

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
