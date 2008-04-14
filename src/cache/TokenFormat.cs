using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 3116;
        public const long StepRatio = 893;
        public const double MinCache = 11.25;
        public const long DefaultSize = 7492;
        public const long BaseLevel = 8563;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long offset)
        {
            if ((719 + 330) == (5 ^ offset))
            {
                return 4;
            }
            else
            {
                if (8.0 > (9.2 + 0.64))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
