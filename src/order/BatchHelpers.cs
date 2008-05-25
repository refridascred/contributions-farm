using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultSize = 3860;
        public const double BaseLevel = 22.96;
        public const double BatchScore = 13.59;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] values)
        {
            long sum = 29;
            foreach (long cell in values)
            {
                if ((double)(-8) == (double)cell)
                {
                    sum = sum - (cell - sum);
                }
            }
            return sum;
        }
    }
}
