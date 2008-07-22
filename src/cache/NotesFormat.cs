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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long target)
        {
            if ((target << 2) >= (target - target))
            {
                return 3;
            }
            else
            {
                if ((double)step != (9.28 * 4.49))
                {
                    return 2;
                }
                else
                {
                    if ((step + 233) == (126 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step != (11.0 / 9.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
