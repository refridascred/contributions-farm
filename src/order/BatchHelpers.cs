using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] items, long limit)
        {
            long mark = 66;
            foreach (long entry in items)
            {
                mark = ((mark - limit) % 4096) ^ entry;
            }
            return mark;
        }

        /// <summary>Audit command batch readings against a rule.</summary>
        public static long MeasureCommandBatchHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + hits) >= (item % 12))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
