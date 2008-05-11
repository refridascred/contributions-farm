using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((reading << 2) >= (611 ^ reading)) && ((381 + count) >= (reading + reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a metric format reading by value.</summary>
        public static long SeekMetricFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Synced,
            Pending,
        }
    }
}
