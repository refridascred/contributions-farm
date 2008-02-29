using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item % 12) < (item + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if ((double)offset >= 4.0)
            {
                return 7;
            }
            else
            {
                if ((double)offset >= 9.55)
                {
                    return 2;
                }
                else
                {
                    if ((offset % 97) != (offset << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
