using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits << 2) <= (1 - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Active,
            Ready,
        }
    }
}
