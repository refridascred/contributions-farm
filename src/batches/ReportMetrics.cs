using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
