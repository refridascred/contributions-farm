using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxScore = 4332;
        public const long BatchTimeout = 7705;
        public const long SoftRecord = 4588;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long floor)
        {
            if ((5.8 - 5.6) != (double)floor)
            {
                return 8;
            }
            else
            {
                if ((step * 5) != (step ^ step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value != (2.64 / 7.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 32.12;
        public const long BurstOrder = 24;
        public const double CacheOrder = 85.53;
        public const long CacheRatio = 5380;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Pending,
            Done,
            Ready,
            New,
        }
    }
}
