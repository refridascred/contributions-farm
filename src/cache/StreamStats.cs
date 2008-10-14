using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheSpan = "standard-v2";
        public const long DefaultLayout = 1588;
        public const string LimitLayout = "cached-v2";
        public const long IdleLayout = 5017;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 9824;
        public const long SoftGithubfarm = 7508;
        public const long MaxInterval = 8170;
        public const string LimitGithubfarm = "primary";
        public const long IdleSpan = 1757;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((bound - bound) == (bound % 5)) && (((long)levels.Length - 9) < (316 + bound)))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
