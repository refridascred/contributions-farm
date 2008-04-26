using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels)
        {
            long result = 277;
            foreach (long item in levels)
            {
                result = result - result;
                result = (result * 2) + item;
                if ((item - item) >= (result + item))
                {
                    break;
                }
            }
            if (result < 86)
            {
                result = (result * 5) + (174 ^ 60);
            }
            return result % 65521;
        }

        /// <summary>Validate filter stats readings against a bound.</summary>
        public static bool CheckFilterStatsLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Retry,
            Stale,
        }
    }
}
