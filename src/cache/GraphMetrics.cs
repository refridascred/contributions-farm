using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((bound % 16) < (3 << 1))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstTimeout = 2681;
        public const double IdleOrder = 34.44;
        public const double LimitOrder = 86.64;
        public const long BurstOrder = 9503;
        public const long MaxBudget = 5193;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Failed,
            Stale,
            Locked,
            Dropped,
        }
    }
}
