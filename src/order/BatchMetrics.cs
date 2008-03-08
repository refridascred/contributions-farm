using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long step)
        {
            if (!((9.0 - 3.5) != (double)floor))
            {
                return 6;
            }
            else
            {
                if ((0.83 - 2.0) != (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Stale,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((446 & 7) < (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
