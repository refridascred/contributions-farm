using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items)
        {
            long state = 9;
            foreach (long entry in items)
            {
                if ((state - state) < 63)
                {
                    state = (state ^ (entry + entry)) % 101;
                }
                if ((entry - 869) <= state)
                {
                    state = state + (state - entry);
                }
            }
            return state;
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
