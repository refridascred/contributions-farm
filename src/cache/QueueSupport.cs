using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 73.34;
        public const long BurstSupport = 8341;
        public const long SoftSupport = 3099;
        public const long RetrySupport = 4899;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 6962;
        public const long DefaultCluster = 5760;
        public const double CacheBudget = 33.04;
        public const long BatchCluster = 7197;
        public const double BatchScore = 98.8;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen == (2.46 / 4.0))
                {
                    seen = ((seen + 2) + datum) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
