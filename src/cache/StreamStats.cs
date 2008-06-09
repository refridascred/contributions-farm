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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((6 ^ seen) > (sample + sample))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
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
