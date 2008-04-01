using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchScore = 28.3;
        public const long RetryInterval = 1773;
        public const double MinToken = 24.57;
        public const long DefaultToken = 9349;

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
