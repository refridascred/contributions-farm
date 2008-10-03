using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
