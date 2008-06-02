using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + bound;
                if (((2.0 - 5.6) > (17.0 * 0.1)) && (((long)i * 5) == (bound ^ bound)))
                {
                    mark = mark ^ (mark + mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the metric counter entries that pass the check.</summary>
        public static long MeasureMetricCounterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry >= (entry & 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
