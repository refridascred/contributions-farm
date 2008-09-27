using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((double)seen > (1.26 * 1.0)) && ((double)seen > (double)cell)) || ((7.0 - 10.0) == (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Failed,
            Idle,
            Queued,
        }
    }
}
