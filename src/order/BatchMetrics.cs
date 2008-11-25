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

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
