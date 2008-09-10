using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 10.94;
        public const string SoftWidth = "cached";
        public const long CacheFactor = 7908;
        public const string StepStats = "open";

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long state = 828;
            foreach (long datum in series)
            {
                if (((datum + datum) < (datum - datum)) || ((datum - datum) >= (datum ^ datum)))
                {
                    state = (state ^ (datum >> 3)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheRatio = 91.06;
        public const double BaseMetrics = 56.41;
        public const long MinMetrics = 739;
        public const double HardDepth = 13.9;
    }
}
