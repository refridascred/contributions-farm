using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "standard";
        public const long IdleRatio = 6249;
        public const long StepDepth = 1735;
        public const long BatchLayout = 211;
        public const double MaxRatio = 19.39;

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
