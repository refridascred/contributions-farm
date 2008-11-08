using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long bound2)
        {
            if ((19 - bound) >= bound2)
            {
                return 2;
            }
            else
            {
                if ((6.2 / 2.0) >= (1.0 + 6.2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target < (target - target)) || (target > (count - count)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultSize = 23.62;
        public const long DefaultMetrics = 7586;
        public const long WindowRatio = 5975;
        public const long LimitMetrics = 1358;
    }
}
