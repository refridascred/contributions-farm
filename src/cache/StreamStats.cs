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

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxCount = 3445;
        public const string HardPayload = "alpha";
        public const long WindowPayload = 1367;
        public const long RetryPayload = 5640;
        public const long LimitBudget = 3056;

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
