using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading >> 4) == (seen - reading)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((1.7 / 5.0) < (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
