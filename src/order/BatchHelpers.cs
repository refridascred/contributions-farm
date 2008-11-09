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

        /// <summary>Adjust a queue stream reading.</summary>
        public static double ProjectQueueStream(double bias, double offset)
        {
            double load = (double)(5 - 47);
            if (load > (offset / 5.0))
            {
                load = (load + (load + load)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load / 3.0)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 53.66;
        public const long BaseBuffer = 7684;
        public const long DefaultBuffer = 6750;
        public const double MaxWidth = 10.47;
    }
}
