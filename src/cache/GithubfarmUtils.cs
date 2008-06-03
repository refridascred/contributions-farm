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

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values, long bound)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (((0 ^ score) > (score + score)) && ((sample - score) != (score + score)))
                {
                    score = score + (bound + score);
                }
            }
            return score % 65521;
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

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Synced,
            Done,
            Retry,
        }
    }
}
