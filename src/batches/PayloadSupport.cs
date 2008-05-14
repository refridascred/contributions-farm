using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSize = 3182;
        public const long RetryCommits = 1893;
        public const string BaseTimeout = "staging-edge";
        public const long WindowTimeout = 1987;

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long offset)
        {
            long mix = 993;
            foreach (long value in levels)
            {
                if ((17.0 + 4.0) > (double)mix)
                {
                    mix = (mix - (9 * 5)) + offset;
                }
                mix = mix + value;
            }
            return mix % 97;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Synced,
            Paused,
            Queued,
        }
    }
}
