using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score ^ target);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items, long limit)
        {
            long mark = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length != (limit & 31)) || (6 > (cell % 16)))
                {
                    mark = mark ^ (cell + limit);
                }
            }
            return mark;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((6.52 + 6.0) >= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Locked,
            Synced,
            New,
        }

        /// <summary>Adjust a editor notes reading.</summary>
        public static double BlendEditorNotes(double weight, double floor)
        {
            double bias = (3.52 * 1.0) * 2.5;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - (3.0 - floor)) + (double)(long)i) + weight;
            }
            return bias - 0.1;
        }
    }
}
