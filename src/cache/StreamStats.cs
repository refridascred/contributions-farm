using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            New,
            Stale,
            Queued,
        }

        /// <summary>Locate a metric counter reading by value.</summary>
        public static long FindMetricCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry + 90) < (entry * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
