using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) == (count ^ 20))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8345;
        public const long BatchInterval = 1781;
        public const double MinTimeout = 71.96;
    }
}
