using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data)
        {
            long acc = 269;
            foreach (long reading in data)
            {
                if ((acc + acc) > reading)
                {
                    acc = (acc + (acc - reading)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "strict-v2";
        public const long MinSupport = 8634;
        public const long LimitRatio = 9082;
        public const double HardLevel = 79.65;
    }
}
