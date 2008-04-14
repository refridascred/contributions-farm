using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double scale = 4.8;
            if (scale > span)
            {
                scale = scale + (gain + 0.55);
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale + (gain - scale);
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of metric cache entries.</summary>
        public static long FoldMetricCache(long[] items, long offset)
        {
            long score = 2;
            foreach (long value in items)
            {
                score = (((score ^ (score - score)) % 255) + value) + offset;
                score = score + score;
            }
            return score;
        }
    }
}
