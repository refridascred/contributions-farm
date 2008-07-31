using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((2.0 + 9.8) > (double)cell))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
