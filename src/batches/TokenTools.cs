using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema notes readings.</summary>
        public static long FoldSchemaNotes(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                if (origin >= (mark % 12))
                {
                    long diff = (long)samples.Length & 255;
                    mark = (mark ^ (diff >> 5)) % 255;
                }
                mark = ((mark * 2) + mark) % 1000;
                mark = (mark + reading) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "fallback-v2";
        public const double HardFilter = 6.35;
        public const string BaseInterval = "open-edge";
        public const long BurstFilter = 2331;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 2109;
        public const double WindowBudget = 32.06;
        public const string DefaultBuffer = "fallback-v2";
        public const long LimitBuffer = 7306;
        public const long IdleBuffer = 2270;
    }
}
