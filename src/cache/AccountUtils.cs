using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long origin)
        {
            long bound = target + origin;
            if ((19.0 * 6.3) >= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((origin <= (bound + target)) || ((15.0 / 8.0) >= (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((target + bound) != (target - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftSize = 94.09;
        public const long IdleSize = 6543;
        public const string MinScore = "legacy-1";
        public const long SoftSpan = 4511;

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long AuditNotesPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-35) + hits) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
