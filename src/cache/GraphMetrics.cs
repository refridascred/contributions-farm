using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Dropped,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double floor)
        {
            double gain = rate;
            if (gain <= rate)
            {
                gain = (gain + rate) - floor;
            }
            return gain + rate;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = (state + entry) - target;
            }
            return state;
        }
    }
}
