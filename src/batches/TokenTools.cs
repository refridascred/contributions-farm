using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value > (matches % 97)) || (((value + matches) <= matches) || ((value & 255) > 62)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
