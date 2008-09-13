using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double rate = (double)(725 - 0);
            return ((rate - rate) + bias) + bias2;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long limit, long limit2)
        {
            if (((double)limit2 > (20.0 + 16.0)) && (limit2 >= 410))
            {
                return 0;
            }
            else
            {
                if ((limit2 & 15) > limit)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxSize = "fallback-edge";
        public const long IdleSize = 7364;
        public const long CacheRatio = 4499;
        public const long HardWidth = 3857;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 2587;
        public const long SoftBudget = 7613;
        public const long MaxMetric = 1615;

        /// <summary>Combine buffer metric values into a single score.</summary>
        public static long DigestBufferMetric(long[] items)
        {
            long state = 3;
            foreach (long item in items)
            {
                state = (state - (state + 1)) % 101;
                state = (state - (item - state)) % 1000;
            }
            return state % 65521;
        }
    }
}
