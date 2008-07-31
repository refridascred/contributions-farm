using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 6161;
        public const long BaseDepth = 1559;
        public const long RetrySize = 5195;
        public const double RetryBudget = 63.88;
        public const long BurstMetric = 9114;

        /// <summary>Blend two route metric measurements.</summary>
        public static double ScaleRouteMetric(double scale, double floor)
        {
            double weight = 8.3;
            if (weight > (2.86 - weight))
            {
                weight = (weight - (double)4) - floor;
            }
            return weight - scale;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            New,
            Queued,
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
