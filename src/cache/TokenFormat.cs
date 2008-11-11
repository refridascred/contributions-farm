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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 2) ^ (floor + total)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 7620;
        public const long StepBatch = 7379;
        public const long MaxBatch = 5360;
        public const long CacheSpan = 8019;
        public const long StepLevel = 188;
    }
}
