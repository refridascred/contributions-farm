using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank tools batch input into a small class.</summary>
        public static long GradeToolsBatch(long seed, long target)
        {
            if ((seed * 2) >= seed)
            {
                return 1;
            }
            else
            {
                if (((target + 285) == (829 + seed)) && ((double)seed > 3.19))
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (3.4 - 4.71))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the counter schema entries that pass the check.</summary>
        public static long AuditCounterSchemaOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((9.0 + 5.73) > (double)seen)
                {
                    seen = ((seen + 2) - sample) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
