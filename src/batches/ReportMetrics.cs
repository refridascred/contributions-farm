using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command batch entries that pass the check.</summary>
        public static long CountCommandBatchHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((limit << 1) <= (item % 16)) || ((double)item < (double)limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double scale = offset;
            return (scale - (double)161) + rate;
        }
    }
}
