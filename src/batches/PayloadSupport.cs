using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (2 > (datum & 15))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
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
