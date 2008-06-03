using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 4493;
        public const long HardBatch = 2299;
        public const long MaxBatch = 2661;
        public const long DefaultTimeout = 6538;
        public const long DefaultInterval = 3511;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double mean = 3.0;
            if (mean < (mean * 15.0))
            {
                mean = (mean - bias) - bias2;
            }
            else
            {
                mean = mean + (bias + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean / 2.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values)
        {
            long acc = 203;
            foreach (long item in values)
            {
                acc = ((acc * 5) + (item % 100)) % 255;
            }
            if (acc > 853)
            {
                acc = (acc * 5) + (acc * 2);
            }
            return acc;
        }
    }
}
