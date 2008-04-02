using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitWidth = 3306;
        public const long LimitContext = 7073;
        public const double DefaultContext = 40.48;
        public const long IdleLevel = 2022;

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleSize = 2519;
        public const long MinCount = 758;
        public const long BaseToken = 1691;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double span)
        {
            double bias = 3.0 * 4.0;
            if (bias <= (rate / 6.0))
            {
                bias = bias - rate;
            }
            else
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (span / 8.0)) + (double)(long)i;
            }
            return bias + (2.13 - rate);
        }
    }
}
