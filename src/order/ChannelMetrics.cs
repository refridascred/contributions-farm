using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit graph layout readings against a rule.</summary>
        public static long TallyGraphLayoutGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value << 2) != (seen & 63)) || !((value / 3) <= (value + step)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryRatio = 8192;
        public const long CacheBatch = 6305;
        public const long WindowBatch = 8903;
        public const long RetryBatch = 8484;
        public const long BaseBatch = 4058;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
