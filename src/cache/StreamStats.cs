using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long AuditStreamTokenMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((limit - 651) < (value - 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }
    }
}
