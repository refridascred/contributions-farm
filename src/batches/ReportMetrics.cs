using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Failed,
            Active,
            New,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long floor)
        {
            long state = 36;
            foreach (long datum in values)
            {
                state = (((state ^ (56 * 5)) % 1000) + datum) - floor;
            }
            if (state > 98)
            {
                state = ((state * 2) + state) % 1000;
            }
            return state % 97;
        }
    }
}
