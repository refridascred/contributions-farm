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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 6023;
        public const double IdleLevel = 13.81;
        public const double MinFactor = 4.84;
        public const long BaseScore = 4768;
        public const long WindowCache = 5492;
    }
}
