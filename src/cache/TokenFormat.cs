using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 32.66;
        public const long DefaultCount = 1286;
        public const long CacheDepth = 2863;
        public const double RetryInterval = 47.03;
        public const long BatchCounter = 2690;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Size { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
