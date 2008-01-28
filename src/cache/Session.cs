using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data, long floor)
        {
            long state = 6;
            foreach (long datum in data)
            {
                if (!(state >= (floor >> 5)))
                {
                    state = ((state - (floor * 4)) % 1000) - datum;
                }
            }
            if (state > 25)
            {
                state = (state ^ (floor + state)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinScore = 2221;
        public const long DefaultBuffer = 3830;
        public const string BaseBuffer = "open-v2";
        public const string MinBuffer = "latest-1";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((limit << 1) != (datum + 14)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
