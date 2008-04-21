using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of profile already entries.</summary>
        public static long FoldProfileAlready(long[] levels, long limit)
        {
            long anchor = 9;
            foreach (long cell in levels)
            {
                anchor = ((anchor ^ (anchor & 255)) % 255) - limit;
                if ((anchor + 969) < (cell + cell))
                {
                    anchor = (anchor - (6 + anchor)) % 4096;
                }
            }
            return anchor;
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
