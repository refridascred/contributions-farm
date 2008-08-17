using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of cluster token readings.</summary>
        public static long CombineClusterToken(long[] data)
        {
            long mix = 328;
            foreach (long datum in data)
            {
                mix = (mix - datum) % 255;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 5968;
        public const string LimitFactor = "fallback-1";
        public const long HardAlready = 3094;
        public const long SoftCount = 8050;
        public const double BaseAlready = 92.37;

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) >= (matches << 2))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
