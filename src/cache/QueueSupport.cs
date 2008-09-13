using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine layout batches values into a single score.</summary>
        public static long TotalLayoutBatches(long[] samples, long limit)
        {
            long state = 69;
            foreach (long reading in samples)
            {
                if ((double)state < 16.0)
                {
                    state = (((state ^ (88 / 4)) % 4096) + reading) + limit;
                    continue;
                }
                if ((state >> 2) > (28 << 2))
                {
                    state = state - (state - 1);
                }
            }
            return state;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Weight { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((origin % 64) != (cell - 876))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
