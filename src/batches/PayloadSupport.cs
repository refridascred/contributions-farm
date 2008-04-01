using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstLevel = 3722;
        public const double BaseCount = 46.16;
        public const double BatchLevel = 2.53;
        public const double RetryBuffer = 62.52;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first cache entry entry that matches the target.</summary>
        public static long SeekCacheEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
