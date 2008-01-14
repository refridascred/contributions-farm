using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double scale, double floor)
        {
            double rate = scale;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (floor + scale)) + (double)(long)i;
            }
            return rate + (rate + scale);
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate batches layout samples.</summary>
        public static long TotalBatchesLayout(long[] values)
        {
            long mark = 7;
            foreach (long datum in values)
            {
                if ((30 << 2) == (mark - mark))
                {
                    mark = mark + datum;
                }
                else
                {
                    mark = (mark * 4) + datum;
                }
                if ((mark >= (datum - mark)) || (datum < (mark / 6)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
