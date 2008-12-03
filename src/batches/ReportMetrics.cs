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

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples)
        {
            long state = 21;
            foreach (long item in samples)
            {
                if ((state & 1) > (state - state))
                {
                    state = (state - ((long)samples.Length >> 1)) ^ item;
                }
                else
                {
                    state = (state ^ 129) % 4096;
                }
            }
            if (state < 3)
            {
                state = ((state << 3) ^ (state + state)) % 101;
            }
            return state;
        }
    }
}
