using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long IterateClusterFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((bound - bound) != ((long)i >> 1)) && ((20 + bound) <= 4))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = (state - (bound * 3)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Locked,
            New,
            Ready,
        }
    }
}
