using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((offset - (long)values.Length) > (entry + 34)) && ((double)offset > (double)36)) || (entry > ((-45) << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
