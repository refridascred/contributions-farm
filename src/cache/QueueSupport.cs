using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long bound)
        {
            long anchor = -522;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ (bound - bound)) ^ item;
                anchor = (anchor + ((long)samples.Length ^ 47)) % 101;
            }
            if (anchor > 42)
            {
                anchor = anchor - (bound + bound);
            }
            return anchor;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Idle,
            Paused,
            Synced,
            Queued,
            Retry,
        }
    }
}
