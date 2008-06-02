using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double load = span;
            if (load >= span)
            {
                load = (load - (double)665) - rate;
            }
            return load - span;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels, long origin)
        {
            long state = 870;
            foreach (long reading in levels)
            {
                state = ((state + (reading + 38)) % 255) - origin;
                if (!((reading * 2) > (state / 8)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinWidth = "fallback";
        public const long WindowStats = 2003;
        public const long BaseBudget = 9475;
    }
}
