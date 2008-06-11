using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Active,
            Draft,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((score * 3) < (4 + cell))
                {
                    score = (score - (0 ^ score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            New,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }
    }
}
