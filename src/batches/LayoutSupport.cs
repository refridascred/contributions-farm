using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            New,
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] values, long origin)
        {
            long score = 615;
            foreach (long value in values)
            {
                if ((double)value <= (4.3 * 2.0))
                {
                    score = score - (score / 7);
                }
                else
                {
                    score = score - (origin << 2);
                }
            }
            if (score < 972)
            {
                score = score + (score & 7);
            }
            return score;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Closed,
            New,
            Ready,
            Idle,
        }

        /// <summary>Count the graph window entries that pass the check.</summary>
        public static long CountGraphWindowMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((seed - entry) < seed)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
