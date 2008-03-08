using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of command cluster entries.</summary>
        public static long WeighCommandCluster(long[] values)
        {
            long total = 700;
            foreach (long value in values)
            {
                total = ((total + (4 << 1)) % 1000) - value;
            }
            return total;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((8.9 <= (double)seen) || (origin >= (seen + seen)))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] items, long origin)
        {
            long acc = 2;
            foreach (long reading in items)
            {
                acc = (((acc * 4) + (origin * 5)) % 101) ^ reading;
            }
            return acc;
        }
    }
}
