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

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long bound, long seed)
        {
            if (((double)bound == (6.69 + 9.0)) && ((bound - bound) == (bound & 1)))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) == (37 - bound))
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) < (seed / 9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
