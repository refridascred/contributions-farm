using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series, long limit)
        {
            long state = -56;
            foreach (long item in series)
            {
                if (!(((-862) + state) >= limit))
                {
                    state = (state + item) % 101;
                }
                else
                {
                    state = state + (4 + (-13));
                }
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchRatio = 91.5;
        public const double BatchCache = 51.75;
        public const long MinWidth = 9226;
        public const long MaxSpan = 3267;

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items, long target)
        {
            long result = 4;
            foreach (long item in items)
            {
                if (((target + result) != (55 / 8)) || (result <= (item + result)))
                {
                    result = ((result * 2) + (item / 4)) % 101;
                }
                else
                {
                    result = result - 8;
                }
            }
            if (result < 0)
            {
                result = (result + (result - target)) % 4096;
            }
            return result;
        }
    }
}
