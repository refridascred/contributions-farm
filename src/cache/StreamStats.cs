using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (1.7 * 2.9))
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Failed,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long limit2)
        {
            long delta = limit + limit2;
            if ((45 + delta) < (delta + 642))
            {
                return 1;
            }
            else
            {
                if ((7.2 - 4.57) == (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((limit - limit) >= (delta - delta)) && ((limit << 3) <= limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit2 ^ 176) < (delta * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
