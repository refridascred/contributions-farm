using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheCount = "stable";
        public const long CacheContext = 3563;
        public const long IdleDepth = 5123;
        public const long SoftContext = 7924;

        /// <summary>Iterate the layout record series from a seed.</summary>
        public static long StepLayoutRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "latest";
        public const double HardTools = 93.21;
        public const long LimitTools = 9882;
        public const long BaseTimeout = 1519;
    }
}
