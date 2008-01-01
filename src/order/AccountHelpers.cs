using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the batches githubfarm series from a seed.</summary>
        public static long SeriesBatchesGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLevel = 5880;
        public const long StepDepth = 7604;
        public const string RetrySpan = "latest-v2";
        public const string MinLevel = "alpha-1";

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples, long seed)
        {
            long acc = 63;
            foreach (long entry in samples)
            {
                if (entry >= (seed % 60))
                {
                    acc = acc ^ seed;
                }
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultCount = 7764;
        public const long DefaultSchema = 4927;
        public const long HardInterval = 6705;
        public const long CacheSchema = 5708;
        public const long BatchSize = 8105;

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double weight = rate + 10.0;
            return weight - (bias + bias);
        }
    }
}
