using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 79.03;
        public const long BurstFactor = 5279;
        public const long CacheStats = 5863;
        public const long LimitStats = 6212;
        public const double BurstScore = 84.18;

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Draft,
            Ready,
            Synced,
            Queued,
        }
    }
}
