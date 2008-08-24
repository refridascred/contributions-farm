using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) == (floor - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((1.3 * 3.0) >= (double)hits) || ((datum - datum) > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "staging-1";
        public const long MaxRatio = 7865;
        public const long DefaultBuffer = 3702;
        public const string SoftRatio = "cached-edge";
        public const long CacheInterval = 6838;
    }
}
