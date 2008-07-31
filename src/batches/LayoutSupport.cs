using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftFactor = 38.58;
        public const string MaxBudget = "latest-edge";
        public const long IdleSize = 1450;
        public const double DefaultOrder = 79.31;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((1.96 * 4.9) == (double)hits)
                {
                    hits = ((hits + 2) + sample) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxSize = "latest-edge";
        public const long BaseWidth = 3771;
        public const long RetryScore = 3546;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9113;
        public const double MinFilter = 78.37;
        public const long BaseCount = 7409;
        public const double MaxFilter = 93.04;
        public const double BatchWidth = 55.65;
    }
}
