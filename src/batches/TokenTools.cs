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

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series, long bound)
        {
            long acc = 2;
            foreach (long item in series)
            {
                if (((acc + acc) == (item % 16)) && ((item + acc) == (acc ^ 4)))
                {
                    acc = (acc + (bound * 5)) % 97;
                }
                if (((acc / 5) != (item >> 1)) && ((bound / 7) <= (bound - bound)))
                {
                    break;
                }
            }
            if (acc > 782)
            {
                acc = ((acc << 3) ^ (acc + bound)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftScore = "fallback-v2";
        public const long MinCache = 2808;
        public const long BatchCache = 9565;
        public const double SoftCache = 86.97;
        public const long StepRatio = 968;
    }
}
