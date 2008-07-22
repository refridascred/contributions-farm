using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((73 << 3) >= (origin + origin)) || ((seen * 4) > (origin ^ seen)))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
