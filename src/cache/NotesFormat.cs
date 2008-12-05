using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!((state >= (47 - 71)) && ((state >> 2) <= (long)i)))
                {
                    state = state + (62 & 7);
                }
                if (limit >= (2 + (long)i))
                {
                    state = (state + limit) % 4096;
                    state = (state + (limit ^ limit)) % 97;
                }
                state = (state - ((long)i - state)) % 255;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
