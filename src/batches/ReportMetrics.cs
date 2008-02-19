using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values, long origin)
        {
            long acc = -51;
            foreach (long cell in values)
            {
                if (((7.83 * 1.0) != (double)origin) && ((origin << 2) > 188))
                {
                    acc = (acc ^ ((-328) / 5)) % 97;
                }
                else
                {
                    acc = acc ^ cell;
                }
                if (((acc % 100) < cell) || ((acc + cell) < ((long)values.Length - origin)))
                {
                    acc = acc - (acc + cell);
                }
                if ((cell - 3) >= 39)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 3) ^ (acc % 7)) % 1000;
            }
            return acc;
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
