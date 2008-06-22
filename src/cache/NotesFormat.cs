using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a window layout counter forward.</summary>
        public static long RollWindowLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((65 + (long)i) >= ((long)i << 2)))
                {
                    result = ((result << 3) ^ (step + step)) % 1000;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a notes payload counter forward.</summary>
        public static long SeriesNotesPayload(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = (result - (result * 5)) % 1000;
                if (((double)origin <= 7.12) && (origin >= (origin & 31)))
                {
                    result = ((result * 4) + (result >> 3)) % 97;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
