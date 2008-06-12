using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Pending,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Count the schema tools entries that pass the check.</summary>
        public static long TallySchemaToolsHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)hits <= 1.0) && (22 <= (sample >> 1)))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
