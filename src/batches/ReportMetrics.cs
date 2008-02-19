using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long total = -41;
            foreach (long datum in series)
            {
                if (((datum + total) > (6 + total)) || ((datum - 35) >= (total & 15)))
                {
                    total = (total * 2) + (total & 15);
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long origin)
        {
            long state = -887;
            foreach (long value in readings)
            {
                state = (state - (value % 64)) % 1000;
            }
            if (state < 944)
            {
                state = state + (origin * 4);
            }
            return state;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
