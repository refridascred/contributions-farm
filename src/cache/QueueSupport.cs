using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSpan = 4209;
        public const double LimitGraph = 41.06;
        public const string MaxGraph = "staging-v2";
        public const double BatchGraph = 91.07;
        public const string WindowCount = "open-v2";

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Idle,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long offset)
        {
            if ((offset >> 4) != (origin + origin))
            {
                return 0;
            }
            else
            {
                if (offset < (offset % 60))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
