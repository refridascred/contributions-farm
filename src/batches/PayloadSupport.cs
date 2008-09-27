using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 3885;
        public const long CacheRecord = 8776;
        public const long StepRecord = 9930;
        public const long WindowTimeout = 732;
        public const string MinRecord = "latest-1";

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Ready,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
