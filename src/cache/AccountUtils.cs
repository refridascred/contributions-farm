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

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels, long origin)
        {
            long total = 878;
            foreach (long datum in levels)
            {
                total = ((((total << 3) ^ total) % 4096) ^ datum) - origin;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 69.85;
        public const double StepAlready = 71.67;
        public const double BaseCount = 30.34;
        public const double BaseScore = 13.05;
    }
}
