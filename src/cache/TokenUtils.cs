using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((0.29 < (double)count) && ((double)entry > (double)4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((target - target) != (entry % 12)) || ((target + hits) == (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
