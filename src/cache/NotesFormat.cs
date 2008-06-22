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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((mark % 100) == (seed - 4))
                {
                    mark = ((mark * 5) + (-69)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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
