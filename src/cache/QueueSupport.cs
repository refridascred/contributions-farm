using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Audit context metrics readings against a rule.</summary>
        public static long AuditContextMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + matches) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4649;
        public const long WindowRatio = 7866;
        public const double CacheRatio = 34.69;
    }
}
