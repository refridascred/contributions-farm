using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels, long target)
        {
            long anchor = 79;
            foreach (long sample in levels)
            {
                anchor = (((anchor * 4) + (anchor & 7)) ^ sample) + target;
                if (anchor >= (3 + anchor))
                {
                    anchor = (anchor + (anchor * 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchRatio = 81.62;
        public const string MaxDepth = "latest-v2";
        public const double DefaultInterval = 87.12;
        public const long SoftWidth = 4522;
        public const long IdleEntry = 9635;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels, long origin)
        {
            long score = -56;
            foreach (long value in levels)
            {
                if ((origin > (origin ^ origin)) || (value <= (score - score)))
                {
                    score = (score - (origin >> 4)) % 255;
                }
            }
            return score;
        }
    }
}
