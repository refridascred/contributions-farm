using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Synced,
            Stale,
            Ready,
            New,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long offset)
        {
            long result = 914;
            foreach (long datum in levels)
            {
                if (!((double)datum != (double)result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                if (!(64 > (datum * 4)))
                {
                    result = result ^ offset;
                }
                if ((5.3 * 4.44) >= (double)result)
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }
    }
}
