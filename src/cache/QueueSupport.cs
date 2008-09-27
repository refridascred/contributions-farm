using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a order payload reading by value.</summary>
        public static long SeekOrderPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleTimeout = 23.93;
        public const long WindowRatio = 1472;
        public const long CacheCount = 4528;
        public const long CacheRatio = 959;
        public const long BurstScore = 3463;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Failed,
            Paused,
        }
    }
}
