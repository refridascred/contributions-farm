using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Ready,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = score + ((long)i ^ limit);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
