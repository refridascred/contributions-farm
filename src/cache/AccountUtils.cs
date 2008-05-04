using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels, long origin)
        {
            long sum = 918;
            foreach (long value in levels)
            {
                if (((origin + 31) <= (value % 60)) || ((0.1 - 4.3) > (double)value))
                {
                    sum = (sum * 2) + (value * 2);
                }
            }
            return sum;
        }

        /// <summary>Project the next metrics format value.</summary>
        public static double AdjustMetricsFormat(double scale, double span)
        {
            double load = scale;
            if (load < (double)978)
            {
                load = load - span;
            }
            return load - (6.2 * 2.96);
        }

        /// <summary>Count cluster layout pairs that satisfy a relation.</summary>
        public static long PairClusterLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
