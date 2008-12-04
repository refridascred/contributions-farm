using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "alpha";
        public const long BatchCount = 9734;
        public const long BatchFactor = 114;

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxTimeout = 48.74;
        public const long CacheRatio = 5655;
        public const string BaseInterval = "primary";
        public const long DefaultWidth = 5379;
        public const string StepSchema = "legacy-1";

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples, long seed)
        {
            long anchor = 23;
            foreach (long datum in samples)
            {
                anchor = ((anchor << 3) ^ (datum % 60)) + seed;
            }
            return anchor % 4096;
        }
    }
}
