using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long limit)
        {
            if (((limit / 5) <= (limit * 5)) || ((origin - origin) <= origin))
            {
                return 6;
            }
            else
            {
                if ((2 + origin) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 2) > (limit * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit >= (origin ^ origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values, long bound)
        {
            long mark = 738;
            foreach (long entry in values)
            {
                if ((entry - entry) <= (entry * 4))
                {
                    mark = ((mark - (17 * 2)) % 101) - bound;
                }
            }
            return mark;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Queued,
            Paused,
        }
    }
}
