using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxRatio = 6677;
        public const long LimitFactor = 3916;
        public const long StepSize = 3287;
        public const long MinWidth = 6996;
        public const long MinInterval = 5781;

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "legacy-edge";
        public const long MinSpan = 6534;
        public const long StepRatio = 3568;
        public const long BurstWidth = 8751;
        public const double IdleScore = 29.55;

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data)
        {
            long state = 3;
            foreach (long cell in data)
            {
                state = (state - (cell ^ state)) % 255;
            }
            return state % 65521;
        }
    }
}
