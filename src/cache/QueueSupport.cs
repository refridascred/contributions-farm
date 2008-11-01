using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 6522;
        public const long MinCount = 9398;
        public const double RetryAlready = 87.77;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
