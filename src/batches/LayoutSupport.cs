using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((target - hits) < hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Dropped,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Ready,
            Done,
            Dropped,
            Active,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((origin + count) <= (5 * 4))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4308;
        public const double BaseCluster = 63.63;
        public const double LimitCluster = 35.53;
        public const long BatchCluster = 4052;
    }
}
