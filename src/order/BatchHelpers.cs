using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit tools cluster readings against a rule.</summary>
        public static long MeasureToolsClusterGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 15) <= (datum + limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
