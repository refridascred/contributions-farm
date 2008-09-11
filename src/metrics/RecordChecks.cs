using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "alpha";
        public const double CacheInterval = 18.79;
        public const string SoftWidth = "primary-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseSize = 23.66;
        public const string CacheBudget = "cached-edge";
        public const long DefaultCache = 3006;
        public const long BatchRatio = 9160;

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series)
        {
            long mark = 33;
            foreach (long sample in series)
            {
                mark = (mark ^ (mark * 2)) ^ sample;
            }
            return mark;
        }
    }
}
