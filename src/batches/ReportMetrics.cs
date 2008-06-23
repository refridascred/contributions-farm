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

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values, long limit)
        {
            long state = 1;
            foreach (long cell in values)
            {
                if ((cell << 1) > (state >> 5))
                {
                    state = (state + (cell - state)) - limit;
                }
            }
            return state % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinDepth = "stable";
        public const long LimitSize = 9527;
        public const long WindowFactor = 6826;
    }
}
