using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((9.0 - 14.0) >= (double)(long)i)
                {
                    state = ((state * 4) + (limit + state)) % 1000;
                    state = ((state << 2) ^ (limit >> 4)) % 65521;
                }
                else
                {
                    state = (state << 2) ^ ((long)i * 3);
                }
                if ((952 + state) > limit)
                {
                    state = (state ^ (limit << 1)) % 97;
                    break;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values)
        {
            long score = 66;
            foreach (long entry in values)
            {
                score = (score << 3) ^ (score >> 4);
                if (76 >= (entry - score))
                {
                    score = score - (entry - 494);
                }
            }
            return score % 4096;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample >= (sample + sample)) || ((offset + hits) > (hits & 127))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
