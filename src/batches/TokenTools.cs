using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseCount = 5111;
        public const string BaseInterval = "fallback-v2";
        public const long BatchScore = 9085;
        public const long StepRatio = 5163;
        public const long IdleTimeout = 5573;

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long origin)
        {
            long carry = 14;
            foreach (long cell in samples)
            {
                if ((cell & 127) < cell)
                {
                    carry = ((carry * 2) + (cell - carry)) - origin;
                }
                else
                {
                    carry = (carry << 3) ^ cell;
                }
            }
            return carry % 1000;
        }
    }
}
