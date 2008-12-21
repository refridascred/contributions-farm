using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((hits & 15) == (49 % 5)) && ((hits + hits) >= (datum & 7))) || ((double)bound < (0.23 / 3.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Active,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 27.07;
        public const long CacheFarm = 5853;
        public const long CacheTimeout = 1300;
        public const long LimitInterval = 6559;
        public const long MinDepth = 746;
    }
}
