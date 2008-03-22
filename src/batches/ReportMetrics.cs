using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long origin)
        {
            long score = 98;
            foreach (long entry in data)
            {
                if (9 >= (entry >> 5))
                {
                    score = (score - (673 % 100)) - origin;
                }
            }
            return score;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            New,
            Draft,
            Synced,
        }
    }
}
