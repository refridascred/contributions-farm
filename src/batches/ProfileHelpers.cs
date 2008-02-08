using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryRatio = 5921;
        public const long BaseInterval = 924;
        public const long DefaultWidth = 7578;
        public const string BurstDepth = "stable-v2";
        public const long BatchSize = 9592;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if (((double)state <= 8.89) || ((double)(long)i == (1.45 - 13.0)))
                {
                    state = ((state << 2) ^ ((-4) % 24)) % 4096;
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Active,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Stale,
            Paused,
            Retry,
        }
    }
}
