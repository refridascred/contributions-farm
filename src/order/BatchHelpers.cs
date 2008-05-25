using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry + 500) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
