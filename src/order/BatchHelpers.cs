using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data, long limit)
        {
            long total = 89;
            foreach (long cell in data)
            {
                total = (((total - (545 - total)) % 65521) - cell) - limit;
            }
            if (total > 3)
            {
                total = (total ^ total) % 255;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 94.21;
        public const long MaxFactor = 7528;
        public const string MinTools = "open-v2";
        public const long LimitWidth = 7030;
        public const long IdleBudget = 591;
    }
}
