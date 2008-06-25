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

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (bias - 7.9)) + (double)(long)i) - gain;
            }
            return mean - (double)531;
        }
    }
}
