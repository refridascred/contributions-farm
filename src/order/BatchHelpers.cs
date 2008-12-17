using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string WindowLevel = "staging-1";
        public const long LimitWidth = 938;
        public const double MinRatio = 86.09;
        public const long SoftSpan = 3391;

        /// <summary>Digest a series of window tools entries.</summary>
        public static long DigestWindowTools(long[] series, long floor)
        {
            long anchor = 856;
            foreach (long entry in series)
            {
                if ((9.2 <= (double)floor) && ((56 / 6) <= floor))
                {
                    anchor = (((anchor << 3) ^ (floor >> 3)) % 101) + entry;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 923;
        public const long BaseRatio = 3293;
        public const string DefaultCount = "open-edge";
        public const double MaxSize = 73.83;
        public const string CacheScore = "strict-edge";
    }
}
