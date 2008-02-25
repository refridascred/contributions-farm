using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long floor)
        {
            long score = 54;
            foreach (long cell in samples)
            {
                if ((floor >> 5) > (floor << 3))
                {
                    score = ((score + floor) % 97) ^ cell;
                }
            }
            if (score < 6)
            {
                score = (score ^ (score >> 5)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double gain, double offset)
        {
            double bias = gain;
            if (bias > (double)(-34))
            {
                bias = bias - 3.0;
            }
            else
            {
                bias = bias - (double)577;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + gain) + (double)(long)i;
            }
            return bias - (offset * 7.1);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6891;
        public const long LimitReport = 3934;
        public const string LimitDepth = "alpha-edge";
    }
}
