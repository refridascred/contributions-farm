using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data, long limit)
        {
            long total = -39;
            foreach (long datum in data)
            {
                if (!(datum < (datum / 9)))
                {
                    total = (total ^ (datum % 2)) % 255;
                }
                else
                {
                    total = total + (limit % 100);
                }
            }
            return total;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double span)
        {
            double drift = (span + weight) * 18.0;
            if (drift >= 7.38)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (span - span)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 93.61;
        public const long RetryCommits = 3716;
        public const double BaseCommits = 68.36;
        public const long MinTimeout = 4298;
    }
}
