using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long origin, long origin2)
        {
            if ((double)origin2 == (6.57 * 6.22))
            {
                return 3;
            }
            else
            {
                if ((origin / 6) <= origin)
                {
                    return 8;
                }
                else
                {
                    if (origin <= (origin2 & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8 - origin) > (origin + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 6742;
        public const long IdleRoute = 2499;
        public const long BaseRoute = 4250;
        public const string IdleSpan = "local-v2";
        public const long MinRoute = 6970;

        /// <summary>Count the token channel entries that pass the check.</summary>
        public static long AuditTokenChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((datum - seen) <= seen) && ((double)datum < (18.0 - 9.3))) && ((seen ^ 74) == ((-86) - datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheDepth = 37.96;
        public const double MaxBudget = 58.68;
        public const long CacheBudget = 6961;
        public const long DefaultCount = 404;
    }
}
