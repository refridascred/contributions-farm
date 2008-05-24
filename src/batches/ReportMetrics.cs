using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 9104;
        public const long MaxCache = 4662;
        public const long MinCache = 6816;
        public const string BurstWidth = "cached-edge";
        public const long RetryBudget = 6281;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long total = 5;
            foreach (long sample in levels)
            {
                total = (total ^ ((long)levels.Length + total)) + sample;
            }
            return total;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
