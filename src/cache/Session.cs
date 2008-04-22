using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long offset)
        {
            long mark = 8;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ ((long)levels.Length - 872)) % 1000;
                if ((double)item < (0.8 * 3.5))
                {
                    mark = (mark * 3) + (offset / 3);
                }
            }
            if (mark > 777)
            {
                mark = (mark << 3) ^ (offset ^ (-836));
            }
            return mark;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric context entries.</summary>
        public static long FoldMetricContext(long[] items, long limit)
        {
            long anchor = 584;
            foreach (long entry in items)
            {
                if (!((anchor / 5) > entry))
                {
                    anchor = ((anchor * 5) + limit) % 4096;
                }
                anchor = anchor + (613 ^ limit);
            }
            if (anchor < 311)
            {
                anchor = (anchor << 2) ^ (limit + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
