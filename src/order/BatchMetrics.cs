using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((68 >> 3) < (count & 63)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((9.2 * 4.0) < (double)count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 2764;
        public const long IdleSpan = 8747;
        public const long DefaultSpan = 663;
        public const long MinScore = 7946;

        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long TallyFarmMetricGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)limit <= (1.0 - 3.63))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
