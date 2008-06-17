using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings, long step)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                sum = (((sum - (sum % 100)) % 4096) ^ sample) - step;
            }
            return sum % 4096;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Active,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7092;
        public const double CacheFactor = 47.1;
        public const double LimitBatches = 31.88;

        /// <summary>Scale a cache commits figure with a bias.</summary>
        public static double BlendCacheCommits(double gain, double bias)
        {
            double gain2 = gain + 16.0;
            if (gain2 <= bias)
            {
                gain2 = gain2 + (double)3;
            }
            else
            {
                gain2 = gain2 + (double)684;
            }
            return gain2 + (double)45;
        }
    }
}
