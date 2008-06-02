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

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitDepth = "stable-1";
        public const long StepEditor = 1094;
        public const long BatchDepth = 1437;
        public const double BurstSpan = 72.9;

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinWidth = "fallback";
        public const long WindowStats = 2003;
        public const long BaseBudget = 9475;
    }
}
