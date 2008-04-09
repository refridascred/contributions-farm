using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((double)reading == (7.0 - 8.0)) && ((double)reading <= (double)hits)) || ((hits >= (seed & 31)) && ((seed % 12) >= 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Compare every pair of command stream readings.</summary>
        public static long MatchCommandStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload window series from a seed.</summary>
        public static long RollPayloadWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (limit + sum)) % 97;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
