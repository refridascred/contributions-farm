using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinSpan = 1587;
        public const long RetryContext = 2205;
        public const double IdleContext = 16.83;

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels)
        {
            long acc = 9;
            foreach (long sample in levels)
            {
                acc = ((acc * 4) + (acc % 24)) % 97;
                acc = ((acc << 2) ^ (sample << 3)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 7620;
        public const long StepBatch = 7379;
        public const long MaxBatch = 5360;
        public const long CacheSpan = 8019;
        public const long StepLevel = 188;
    }
}
