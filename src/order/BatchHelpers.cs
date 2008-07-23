using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Locked,
            Closed,
            Idle,
            Active,
        }

        /// <summary>Iterate the counter batch series from a seed.</summary>
        public static long IterateCounterBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
