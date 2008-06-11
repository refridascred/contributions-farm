using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchBudget = 47.87;
        public const long BurstChecks = 6677;
        public const double RetryInterval = 54.77;
        public const string DefaultChecks = "open-edge";
        public const long IdleBudget = 4177;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] readings)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                mix = (mix + (mix ^ reading)) % 4096;
                if (!((reading - 358) >= (mix + reading)))
                {
                    mix = mix + mix;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (target < ((long)data.Length / 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
