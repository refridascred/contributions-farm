using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batches channel value.</summary>
        public static double ScaleBatchesChannel(double bias, double span)
        {
            double scale = span;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + scale) - (double)(long)i) + bias;
            }
            return scale - (scale * 11.0);
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long diff = limit + offset;
            if ((offset + limit) >= diff)
            {
                return 7;
            }
            else
            {
                if ((diff - diff) <= (offset / 9))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 53.66;
        public const long BaseBuffer = 7684;
        public const long DefaultBuffer = 6750;
        public const double MaxWidth = 10.47;
    }
}
