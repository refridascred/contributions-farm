using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((1.77 + 19.0) < (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches tools readings.</summary>
        public static long TotalBatchesTools(long[] items, long seed)
        {
            long mark = 714;
            foreach (long datum in items)
            {
                if ((72 << 3) < mark)
                {
                    mark = (((mark + (mark / 2)) % 1000) + datum) - seed;
                }
            }
            return mark % 97;
        }
    }
}
