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

        /// <summary>Validate session stats readings against a bound.</summary>
        public static bool CheckSessionStatsBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((step - (long)levels.Length) > entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
