using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (9.0 >= (double)seen)
                {
                    seen = ((seen + 2) ^ datum) - offset;
                }
            }
            return seen;
        }

        /// <summary>Find the first payload metric entry that matches the target.</summary>
        public static long LookupPayloadMetricIndex(long[] readings, long floor)
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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count & 255) < count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
