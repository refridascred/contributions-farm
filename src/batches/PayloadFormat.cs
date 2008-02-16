using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a metric payload reading by value.</summary>
        public static long FindMetricPayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long MeasureProfileCacheOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((count & 3) > (reading - reading)) && (count >= (count ^ 433))))
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

        /// <summary>Derive the next context profile value from a seed.</summary>
        public static long IterateContextProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (seed - mark)) % 4096;
                mark = mark + (mark * 4);
                mark = mark - (-49);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the notes tools entries that pass the check.</summary>
        public static long MeasureNotesToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (reading - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
