using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            New,
            Active,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((offset % 64) <= (mix * 5)))
                {
                    mix = (mix + offset) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
