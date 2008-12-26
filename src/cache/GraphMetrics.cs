using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long sum = -498;
            foreach (long item in levels)
            {
                sum = ((sum ^ (152 >> 1)) ^ item) + origin;
            }
            return sum % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item / 2) > (hits >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
