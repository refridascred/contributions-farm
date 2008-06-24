using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 13.81;
        public const long LimitContributi = 1215;
        public const string WindowBudget = "alpha";
        public const double MinLevel = 79.64;
        public const long WindowScore = 9539;

        /// <summary>Define route limits and defaults.</summary>
        public const string MinDepth = "stable";
        public const long LimitSize = 9527;
        public const long WindowFactor = 6826;
    }
}
