using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every editor contributi entry stays within the limit.</summary>
        public static bool GuardEditorContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < step)
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
