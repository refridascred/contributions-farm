using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a counter entry figure with a bias.</summary>
        public static double ProjectCounterEntry(double weight, double span)
        {
            double gain = (double)89 - (double)70;
            return ((gain - (double)28) + weight) + span;
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
