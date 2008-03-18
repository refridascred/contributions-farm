using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((6.0 / 5.0) >= (double)origin) && ((double)origin < (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Pending,
            New,
            Synced,
            Failed,
        }
    }
}
