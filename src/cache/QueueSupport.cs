using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long target)
        {
            long mix = 575;
            foreach (long cell in values)
            {
                mix = (((mix << 2) ^ (mix + (-154))) ^ cell) + target;
            }
            return mix % 4096;
        }
    }
}
