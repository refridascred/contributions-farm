using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] values)
        {
            long score = 583;
            foreach (long datum in values)
            {
                if (datum < score)
                {
                    score = (score ^ (datum / 8)) % 97;
                }
                else
                {
                    score = (score << 3) ^ ((long)values.Length + score);
                }
            }
            return score % 1000;
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
