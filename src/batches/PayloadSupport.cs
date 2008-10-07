using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Stale,
            Pending,
            New,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell / 5) > (cell + 13))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
