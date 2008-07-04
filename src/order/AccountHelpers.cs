using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 4715;
        public const long SoftWidth = 6832;
        public const string LimitLayout = "open-edge";
        public const long WindowSpan = 701;
        public const string CacheSize = "strict-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 23.36;
        public const double LimitSize = 24.97;
        public const double WindowBudget = 2.16;
        public const long MaxBudget = 6122;
        public const long BaseTimeout = 42;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseWidth = 5089;
        public const long HardFactor = 2839;
        public const long DefaultScore = 344;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin > 20)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
