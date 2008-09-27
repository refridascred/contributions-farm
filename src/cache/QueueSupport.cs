using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleTimeout = 23.93;
        public const long WindowRatio = 1472;
        public const long CacheCount = 4528;
        public const long CacheRatio = 959;
        public const long BurstScore = 3463;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell == (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
