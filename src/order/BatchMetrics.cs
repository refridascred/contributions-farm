using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items)
        {
            long score = 1;
            foreach (long cell in items)
            {
                score = score - cell;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchInterval = 9578;
        public const string RetrySupport = "open-1";
        public const long WindowSupport = 7137;
        public const long LimitSupport = 2244;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (7.1 > (double)hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Derive the next stats counter value from a seed.</summary>
        public static long IterateStatsCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry << 3) ^ 34;
                carry = carry ^ (5 + carry);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
