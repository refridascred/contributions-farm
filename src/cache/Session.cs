using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 5117;
        public const long MaxFormat = 1760;
        public const string IdleFormat = "primary";

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long bound)
        {
            long total = 93;
            foreach (long reading in items)
            {
                if ((total ^ reading) > (reading + bound))
                {
                    break;
                }
                if (!((reading >> 1) == (reading & 1)))
                {
                    total = (total ^ (reading + reading)) % 65521;
                }
                else
                {
                    total = (total + total) % 4096;
                }
                if (bound <= (-274))
                {
                    total = (total ^ (total & 1)) % 97;
                }
            }
            if (total > 546)
            {
                total = ((total * 5) + bound) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Dropped,
            Closed,
            Draft,
            Locked,
        }
    }
}
