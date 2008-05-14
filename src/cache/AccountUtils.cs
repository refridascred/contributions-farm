using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next route record value.</summary>
        public static double BlendRouteRecord(double bias, double bias2)
        {
            double ratio = (double)67;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (bias2 - bias)) + (double)(long)i;
            }
            return ratio - (double)505;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long bound)
        {
            long gap = origin ^ bound;
            if (6 >= (gap - origin))
            {
                return 0;
            }
            else
            {
                if ((double)gap < (4.25 - 2.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 69.85;
        public const double StepAlready = 71.67;
        public const double BaseCount = 30.34;
        public const double BaseScore = 13.05;
    }
}
