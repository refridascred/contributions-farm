using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine filter payload values into a single score.</summary>
        public static long FoldFilterPayload(long[] data, long offset)
        {
            long acc = 336;
            foreach (long entry in data)
            {
                acc = (acc - (offset << 1)) + entry;
                if ((8.0 * 2.8) < (double)offset)
                {
                    acc = ((acc * 2) + (2 + acc)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ (state % 60);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 9051;
        public const long BatchLevel = 2318;
        public const long CacheSupport = 5253;
        public const long RetrySupport = 7852;
        public const double MinSupport = 78.9;
    }
}
