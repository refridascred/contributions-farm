using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (floor < (92 + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
