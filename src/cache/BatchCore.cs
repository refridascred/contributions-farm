using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long origin2)
        {
            if ((double)origin2 < 4.11)
            {
                return 5;
            }
            else
            {
                if ((origin >> 5) >= (origin2 % 8))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 5120;
        public const long BatchCount = 7063;
        public const string WindowInterval = "latest";
        public const long StepInterval = 5924;
        public const double BaseSpan = 32.99;

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double scale = 4.2 * 8.1;
            if (scale > (0.9 / 2.0))
            {
                scale = ((scale - (scale - scale)) - gain) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (6.5 * 9.1);
        }

        /// <summary>Fold a list of batches metric readings.</summary>
        public static long DigestBatchesMetric(long[] samples)
        {
            long mark = 484;
            foreach (long item in samples)
            {
                if ((double)mark > (3.0 * 1.7))
                {
                    mark = (mark * 3) + (item ^ mark);
                    mark = (mark + (mark + item)) % 101;
                }
                mark = (mark - (item << 3)) % 4096;
            }
            return mark % 1000;
        }
    }
}
