using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool GuardOrderStatsBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 3.97;
        public const long MinCommand = 8660;
        public const double BurstWidth = 34.44;
        public const long LimitCount = 5227;
        public const double IdleBudget = 28.88;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long score = 6;
            foreach (long item in samples)
            {
                if (7.85 < (double)score)
                {
                    score = (score - (score + item)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (5.44 / 4.0))
            {
                mean = mean + (bias * 16.0);
            }
            else
            {
                mean = mean + (bias * 5.5);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (offset - 4.57)) + (double)(long)i;
            }
            return mean - (double)77;
        }
    }
}
