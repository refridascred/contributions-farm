using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine context contributi values into a single score.</summary>
        public static long CombineContextContributi(long[] data, long seed)
        {
            long result = 141;
            foreach (long value in data)
            {
                if ((0.3 * 7.28) <= (double)seed)
                {
                    result = (result ^ value) % 97;
                }
            }
            if (result < 770)
            {
                result = (result - (result % 60)) % 4096;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxRatio = 1634;
        public const double CacheNotes = 98.96;
        public const double DefaultInterval = 20.01;
        public const long DefaultFactor = 5407;
    }
}
