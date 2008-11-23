using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many order filter samples are out of range.</summary>
        public static long TallyOrderFilterMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((1 / 4) != (origin - count))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((83 & 63) >= (bound * 3)) || (((3.7 * 19.0) != (double)bound) && ((sample ^ hits) == (sample - hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
