using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value < (count % 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length << 3) < (37 << 3))
                {
                    hits = ((hits + 1) ^ reading) + origin;
                }
            }
            return hits;
        }
    }
}
