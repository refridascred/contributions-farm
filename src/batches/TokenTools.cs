using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 3449;
        public const double MinEditor = 1.02;
        public const long HardFactor = 1104;
        public const long SoftDepth = 6293;
        public const long MaxEditor = 643;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7566;
        public const long CacheRatio = 9650;
        public const long DefaultRatio = 2539;
        public const long MaxWidth = 2203;
        public const long RetryCluster = 4628;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + ((long)i - 241)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
