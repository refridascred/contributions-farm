using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 6063;
        public const string HardFactor = "alpha";
        public const long MinLevel = 5421;
        public const long DefaultLevel = 6833;
        public const string DefaultFilter = "staging-1";

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 3) > item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
