using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            New,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 6670;
        public const long DefaultWindow = 8489;
        public const long MaxRatio = 2442;
    }
}
