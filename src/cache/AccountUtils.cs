using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 3800;
        public const long MaxInterval = 6939;
        public const double BaseInterval = 21.15;
        public const string WindowOrder = "standard-v2";

        /// <summary>Fold a list of context already readings.</summary>
        public static long TotalContextAlready(long[] items, long limit)
        {
            long score = -1;
            foreach (long item in items)
            {
                if ((2.57 - 2.77) < (double)score)
                {
                    score = (score + item) + limit;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches << 2) != (cell >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
