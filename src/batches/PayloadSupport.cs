using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((24 ^ item) > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Failed,
            Retry,
            Pending,
            Closed,
        }
    }
}
