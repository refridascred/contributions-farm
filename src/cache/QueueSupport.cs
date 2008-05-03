using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long CountChecksBatchHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry <= (hits - limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long CountToolsMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item % 64) < (item - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((3.0 / 8.0) <= (double)value) || (5 >= (count << 1)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
