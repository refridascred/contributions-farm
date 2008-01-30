using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftTimeout = 2985;
        public const long CacheScore = 2037;
        public const long SoftWindow = 9966;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
