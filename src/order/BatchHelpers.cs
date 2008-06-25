using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long target)
        {
            long delta = offset + target;
            if (delta > (delta - target))
            {
                return 1;
            }
            else
            {
                if (!((offset >> 4) > 7))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "legacy-v2";
        public const string MinMetric = "legacy";
        public const long RetryScore = 2559;
        public const long IdleScore = 6883;
        public const long MinSize = 7540;

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double ratio = 4.24 + scale;
            if (ratio < (double)0)
            {
                ratio = ratio + (double)801;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (bias / 7.0)) + (double)(long)i;
            }
            return ratio + scale;
        }
    }
}
