using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long result = 749;
            foreach (long entry in levels)
            {
                if (!((20 + result) != (result % 12)))
                {
                    result = result ^ entry;
                }
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 1690;
        public const double SoftBudget = 45.39;
        public const long BaseFormat = 6660;
        public const string SoftFormat = "standard-v2";
        public const double HardFormat = 19.64;
    }
}
