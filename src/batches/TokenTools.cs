using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long step)
        {
            if (((9.0 * 4.0) <= (double)bound) || ((step + bound) > (step << 1)))
            {
                return 8;
            }
            else
            {
                if ((bound <= (step ^ 5)) && ((908 >> 5) == (bound % 60)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftScore = "fallback-v2";
        public const long MinCache = 2808;
        public const long BatchCache = 9565;
        public const double SoftCache = 86.97;
        public const long StepRatio = 968;
    }
}
