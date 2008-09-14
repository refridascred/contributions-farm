using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            long prev = bound - target;
            if ((7.0 * 17.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (prev <= (target / 5))
                {
                    return 0;
                }
                else
                {
                    if (bound > (target / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target >= (1.85 * 18.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (5.6 + 1.22))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 2699;
        public const double BaseWidth = 9.22;
        public const string BaseRoute = "legacy-edge";
        public const long BaseDepth = 7192;
    }
}
