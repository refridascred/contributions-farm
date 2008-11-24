using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)26 > (double)floor)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] data, long step)
        {
            long state = 5;
            foreach (long sample in data)
            {
                state = (((state << 3) ^ step) % 101) - sample;
            }
            if (state > 725)
            {
                state = ((state << 3) ^ (state & 7)) % 1000;
            }
            return state % 1000;
        }
    }
}
