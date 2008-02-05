using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 786;
        public const string BatchLayout = "fallback-1";
        public const long RetryLayout = 9596;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((datum > (6 % 24)) && ((matches >> 3) > 13)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
