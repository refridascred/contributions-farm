using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (2.0 > (double)hits)
                {
                    hits = ((hits + 2) + datum) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples, long target)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                if ((0 % 3) != (target ^ sum))
                {
                    sum = ((sum - (target * 2)) % 65521) + value;
                }
            }
            return sum;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((offset >= (offset % 16)) || ((0.57 / 8.0) != (double)sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
