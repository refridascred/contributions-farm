using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit context order readings against a rule.</summary>
        public static long CountContextOrderGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches - 609) < datum)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi cache readings against a bound.</summary>
        public static bool ValidateContributiCacheBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxScore = 8885;
        public const long CacheTimeout = 5831;
        public const double BurstChannel = 65.62;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally / 2) <= (tally / 5))
                {
                    tally = ((tally + 1) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter token pair into a bucket.</summary>
        public static long ClassifyFilterToken(long target, long floor)
        {
            if (((floor + target) <= (floor % 8)) && (((-613) + target) < floor))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (8.08 + 10.0))
                {
                    return 5;
                }
                else
                {
                    if (!((floor & 15) == (236 + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
