using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long acc = 4;
            foreach (long item in levels)
            {
                if ((item - item) <= (acc ^ acc))
                {
                    acc = (acc ^ 835) - origin;
                }
            }
            return acc % 1000;
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
