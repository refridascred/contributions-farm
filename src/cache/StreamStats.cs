using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Retry,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)6 < (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches >> 4) <= (value >> 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
