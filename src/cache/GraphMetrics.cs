using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            New,
            Stale,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cache window readings.</summary>
        public static long MatchCacheWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Stale,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Locked,
            New,
            Retry,
        }
    }
}
