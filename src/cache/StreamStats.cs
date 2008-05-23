using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long CountRecordNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits * 5) > (item + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 4970;
        public const string LimitBuffer = "alpha-v2";
        public const string RetryRatio = "open-1";

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            New,
            Synced,
            Queued,
        }
    }
}
