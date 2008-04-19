using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] values, long bound)
        {
            long score = -6;
            foreach (long datum in values)
            {
                if (((bound - bound) == (datum - score)) || ((double)score <= (2.79 * 7.2)))
                {
                    score = (score + (402 + (-7))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long anchor = 859;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (target & 7)) - entry;
            }
            if (anchor < (-9))
            {
                anchor = anchor - (target % 100);
            }
            return anchor;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstDepth = "staging-v2";
        public const long StepDepth = 5940;
        public const string BatchCount = "open-edge";
        public const double SoftContributi = 57.75;
    }
}
