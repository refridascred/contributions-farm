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

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 8000;
        public const long BaseRatio = 5471;
        public const long StepStats = 1531;

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftFactor = "local";
        public const string RetrySize = "stable-v2";
        public const long DefaultSupport = 5013;

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
