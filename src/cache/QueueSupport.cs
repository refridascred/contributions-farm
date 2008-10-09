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
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cache counter entry that matches the target.</summary>
        public static long LocateCacheCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long StepEntryAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + (1 + limit);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
