using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the batches session entries that pass the check.</summary>
        public static long AuditBatchesSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen & 15) >= (sample + 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstFactor = "cached-v2";
        public const string DefaultToken = "latest-1";
        public const long CacheSpan = 9377;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 1072;
        public const string LimitLevel = "staging-edge";
        public const double MinFilter = 85.17;
    }
}
