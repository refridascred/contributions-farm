using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long step)
        {
            long state = -37;
            foreach (long entry in series)
            {
                if (state > (step / 4))
                {
                    state = (state + (entry - step)) % 1000;
                }
                else
                {
                    state = (state ^ (state % 10)) % 101;
                }
            }
            if (state < (-883))
            {
                state = state ^ step;
            }
            return state % 65521;
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
