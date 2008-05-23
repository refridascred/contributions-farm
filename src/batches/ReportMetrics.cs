using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double drift = weight;
            if (drift <= offset)
            {
                drift = drift - (double)94;
            }
            return drift - (drift * 9.29);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1830;
        public const double MinCluster = 53.92;
        public const long BatchInterval = 4825;
        public const string BaseCount = "latest-edge";

        /// <summary>Count command cluster pairs that satisfy a relation.</summary>
        public static long CompareCommandClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
