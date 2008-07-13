using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheDepth = "open";
        public const long SoftMetrics = 3506;
        public const double RetryMetrics = 63.46;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long score = 79;
            foreach (long reading in readings)
            {
                score = (score << 2) ^ (reading - reading);
            }
            return score;
        }
    }
}
