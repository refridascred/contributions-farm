using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Pending,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= 76)
                {
                    count = ((count + 2) + datum) - origin;
                }
            }
            return count;
        }
    }
}
