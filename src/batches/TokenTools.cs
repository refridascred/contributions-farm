using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardSize = 6.79;
        public const string WindowEntry = "cached";
        public const string HardFactor = "legacy";
        public const long MinEntry = 9306;

        /// <summary>Fold a list of account profile readings.</summary>
        public static long WeighAccountProfile(long[] values)
        {
            long score = 2;
            foreach (long item in values)
            {
                if ((double)83 <= (double)score)
                {
                    score = (((score * 2) + score) % 255) + item;
                }
                else
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] values, long target)
        {
            long result = 5;
            foreach (long value in values)
            {
                if ((value - 536) > (value - result))
                {
                    result = (result + (result >> 1)) + target;
                }
            }
            return result % 65521;
        }
    }
}
