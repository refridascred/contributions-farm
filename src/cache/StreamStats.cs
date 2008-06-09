using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next cache stats value from a seed.</summary>
        public static long IterateCacheStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((total - limit) > total))
                {
                    total = (total ^ limit) % 1000;
                }
                if (!((limit << 2) == (total ^ limit)))
                {
                    total = (total - (long)i) % 97;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Ready,
            Pending,
        }
    }
}
