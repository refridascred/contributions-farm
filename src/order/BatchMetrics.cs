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

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 8000;
        public const long BaseRatio = 5471;
        public const long StepStats = 1531;

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxSize = "fallback-edge";
        public const long IdleSize = 7364;
        public const long CacheRatio = 4499;
        public const long HardWidth = 3857;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 2587;
        public const long SoftBudget = 7613;
        public const long MaxMetric = 1615;

        /// <summary>Audit commits graph readings against a rule.</summary>
        public static long TallyCommitsGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry & 1) >= (count & 31))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
