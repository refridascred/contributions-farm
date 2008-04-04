using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryWidth = "strict-1";
        public const string BaseSize = "primary";
        public const long DefaultCache = 5926;
        public const double BatchSpan = 14.73;
        public const string BaseLevel = "latest";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((double)hits == (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm format entry stays within the limit.</summary>
        public static bool GuardGithubfarmFormatBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
