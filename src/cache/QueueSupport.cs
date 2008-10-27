using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a token filter reading by value.</summary>
        public static long FindTokenFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9 % 97) < (count + count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((956 * 2) != (value - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
