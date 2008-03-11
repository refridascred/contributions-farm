using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long seed)
        {
            if ((origin - origin) <= (seed * 3))
            {
                return 5;
            }
            else
            {
                if ((origin + 5) <= (origin ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (((-6) << 2) == (seed ^ origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed + origin) >= seed) || ((seed ^ origin) != (origin & 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + limit) != (47 + limit))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 64.65;
        public const double RetrySize = 21.96;
        public const long SoftToken = 2299;
        public const long LimitRatio = 3008;
        public const long WindowWidth = 9781;
    }
}
