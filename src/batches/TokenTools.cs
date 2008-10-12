using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit account stats readings against a rule.</summary>
        public static long AuditAccountStatsGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally / 6) < offset)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long floor, long origin)
        {
            if ((7.0 * 1.5) >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((3.19 / 2.0) <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (!((floor >> 3) != (floor << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
