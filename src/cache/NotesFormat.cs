using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((bound + 35) <= (bound % 12))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!(limit < (long)i))
                {
                    state = ((state << 3) ^ limit) % 65521;
                }
                state = (state * 2) + ((long)i << 3);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < 14.0) || ((double)cell >= (1.0 * 17.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
