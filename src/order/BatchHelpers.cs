using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheCount = 7193;
        public const long IdlePayload = 5986;
        public const double MinPayload = 2.17;

        /// <summary>Measure how many route support samples are out of range.</summary>
        public static long AuditRouteSupportHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits + value) > bound)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] readings)
        {
            long total = -45;
            foreach (long entry in readings)
            {
                if (((549 + entry) > (entry & 31)) && ((double)entry == (4.0 + 19.0)))
                {
                    total = ((total * 5) + (entry + total)) % 1000;
                }
                else
                {
                    total = (total + (total ^ entry)) % 4096;
                }
            }
            if (total > 766)
            {
                total = (total ^ total) % 1000;
            }
            return total % 65521;
        }
    }
}
