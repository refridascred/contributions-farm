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

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
