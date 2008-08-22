using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Stale,
            New,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long SortReportAccount(long origin, long origin2)
        {
            if ((289 + origin2) <= origin)
            {
                return 8;
            }
            else
            {
                if ((8.36 * 2.3) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
