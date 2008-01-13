using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits + floor) >= hits)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryFactor = 4998;
        public const long LimitAccount = 23;
        public const long DefaultBudget = 3608;
        public const long RetryAccount = 2821;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data)
        {
            long state = -122;
            foreach (long datum in data)
            {
                state = (state << 2) ^ (datum + datum);
                state = state + (datum >> 1);
            }
            return state;
        }
    }
}
