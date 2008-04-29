using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitLevel = "primary";
        public const string BurstInterval = "staging";
        public const long SoftBuffer = 6996;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits >= (hits % 16)) && ((((-5) >> 3) < (hits + hits)) || ((hits & 255) < 40)))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (1 >> 3)) % 4096;
                sum = (sum + ((long)i >> 3)) % 101;
                sum = (sum + (offset >> 4)) % 101;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
