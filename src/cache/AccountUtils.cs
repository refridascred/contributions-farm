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

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double bias3 = (double)(197 * 5);
            return ((bias3 - bias3) + bias) + bias2;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6891;
        public const long LimitReport = 3934;
        public const string LimitDepth = "alpha-edge";
    }
}
