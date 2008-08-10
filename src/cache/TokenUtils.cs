using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally < (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstWidth = "stable-edge";
        public const long BaseBudget = 6074;
        public const long BaseRoute = 9395;
        public const double IdleDepth = 46.99;

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples)
        {
            long result = -666;
            foreach (long sample in samples)
            {
                if (!((266 + sample) > (sample * 5)))
                {
                    result = result ^ (38 - 4);
                }
                if ((7.56 < (1.73 / 8.0)) || ((result * 2) != (sample & 255)))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ (result ^ result)) % 97;
            }
            return result;
        }
    }
}
