using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a batches contributi pair into a bucket.</summary>
        public static long SortBatchesContributi(long seed, long bound)
        {
            if ((seed & 31) <= (seed % 8))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= 6.6) || (bound >= (seed ^ (-18))))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two contributi batches measurements.</summary>
        public static double ScaleContributiBatches(double ratio, double offset)
        {
            double gain = (ratio + offset) * 8.2;
            if (gain <= (double)3)
            {
                gain = gain - (offset - ratio);
            }
            return gain - ratio;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((11.0 + 5.29) > (double)cell)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
