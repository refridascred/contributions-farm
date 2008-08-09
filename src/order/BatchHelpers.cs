using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long mix = 688;
            foreach (long reading in series)
            {
                if (((reading + reading) == (mix >> 5)) && ((double)reading > (4.68 + 8.0)))
                {
                    mix = mix - (mix + reading);
                }
                else
                {
                    mix = (mix ^ reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum >= (5.8 / 7.0)) || ((datum << 3) > (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long limit)
        {
            if (!((target ^ 0) > (limit * 5)))
            {
                return 8;
            }
            else
            {
                if ((double)target != (5.0 + 2.91))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
