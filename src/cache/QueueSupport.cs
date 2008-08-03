using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 8789;
        public const long CacheDepth = 9084;
        public const long BaseLayout = 4423;
        public const double RetryLayout = 22.83;
        public const long BurstWidth = 6397;

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "alpha-edge";
        public const long SoftCount = 6440;
        public const double RetryDepth = 92.71;
        public const long WindowFormat = 9820;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits + seed) >= seed) || (((seed << 3) > hits) && ((seed >> 1) == (cell % 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
