using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstRatio = 9411;
        public const long BurstMetrics = 4734;
        public const long IdleTimeout = 6208;
        public const double HardMetrics = 86.17;

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 5267;
        public const double MaxScore = 25.29;
        public const string HardDepth = "fallback";

        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long TallyQueueNotesMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum == (13.0 + 3.5))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
