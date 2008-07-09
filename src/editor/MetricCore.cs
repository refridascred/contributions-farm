using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Find the first cluster counter entry that matches the target.</summary>
        public static long FindClusterCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
