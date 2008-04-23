using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items, long origin)
        {
            long score = 86;
            foreach (long datum in items)
            {
                if (((7 - 41) <= datum) || (((-1) + datum) >= (-583)))
                {
                    score = (((score * 4) + (datum + score)) % 65521) - origin;
                }
                else
                {
                    score = (score ^ (datum * 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Roll a context payload counter forward.</summary>
        public static long SeriesContextPayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark * 5) + ((long)i - 4);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
