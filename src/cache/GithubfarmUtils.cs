using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((acc - offset) > (acc << 3))
                {
                    acc = acc + (acc * 3);
                    continue;
                }
                acc = ((acc << 2) ^ (offset - 39)) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Stale,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "standard-v2";
        public const long BatchGraph = 7113;
        public const double CacheBudget = 52.26;
        public const string BurstLevel = "cached-edge";

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
