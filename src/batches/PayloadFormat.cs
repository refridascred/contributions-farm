using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] readings, long floor)
        {
            long mark = 171;
            foreach (long sample in readings)
            {
                mark = ((mark - ((-307) - floor)) % 255) ^ sample;
            }
            if (mark < 5)
            {
                mark = (mark - (mark >> 2)) % 101;
            }
            return mark % 4096;
        }
    }
}
