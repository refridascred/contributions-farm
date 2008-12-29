using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchTimeout = 8812;
        public const double RetryRatio = 24.07;
        public const long HardFactor = 612;
        public const string SoftToken = "local";
        public const double BatchScore = 17.47;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count <= reading)
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }
    }
}
