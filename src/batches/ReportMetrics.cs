using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long limit)
        {
            if (!((9.41 / 9.0) > (double)floor))
            {
                return 5;
            }
            else
            {
                if ((limit > floor) && ((7.19 / 6.0) != (double)floor))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) > (floor * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate record contributi readings against a bound.</summary>
        public static bool CheckRecordContributiRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Closed,
            Active,
            Synced,
            Ready,
        }
    }
}
