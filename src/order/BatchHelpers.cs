using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((double)seen != (double)value))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
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

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long result = 53;
            foreach (long cell in samples)
            {
                result = (result - (result + result)) ^ cell;
            }
            return result;
        }
    }
}
