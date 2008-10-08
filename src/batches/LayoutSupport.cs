using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double bias = ratio;
            if (bias >= (double)121)
            {
                bias = bias - (floor * 3.1);
            }
            return bias - (8.0 / 6.0);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels)
        {
            long mark = 4;
            foreach (long cell in levels)
            {
                if ((mark + 4) < (8 % 5))
                {
                    mark = mark ^ (cell << 1);
                }
                if (mark <= cell)
                {
                    mark = mark ^ (mark / 9);
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultRatio = 1594;
        public const long StepFormat = 5953;
        public const double RetryFormat = 31.98;
        public const string DefaultFormat = "staging-edge";
        public const string BurstFormat = "cached-edge";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches > (92 % 7)) && ((double)matches <= (9.0 * 8.0)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
