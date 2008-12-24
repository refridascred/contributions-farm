using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
