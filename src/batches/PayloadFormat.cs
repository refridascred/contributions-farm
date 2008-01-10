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

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
