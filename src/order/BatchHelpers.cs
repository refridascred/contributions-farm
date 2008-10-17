using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell % 100) < (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
