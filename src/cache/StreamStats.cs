using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 1988;
        public const long MaxSpan = 6694;
        public const long CacheReport = 2550;
        public const long LimitDepth = 3876;

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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((seen + bound) >= (reading + reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
