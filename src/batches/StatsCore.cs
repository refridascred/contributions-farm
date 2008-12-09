using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long bound2)
        {
            if ((bound2 + bound2) <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound < (bound << 3)) && ((bound * 3) != (bound2 / 6)))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 - bound) < ((-39) / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit commits format readings against a rule.</summary>
        public static long CountCommitsFormatMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + (-102)) == (datum / 5))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((bound / 9) > (53 + 8))
            {
                return 4;
            }
            else
            {
                if ((origin <= (4 + bound)) && ((-8) > origin))
                {
                    return 8;
                }
                else
                {
                    if ((span % 7) <= span)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long FoldFormatCache(long[] items)
        {
            long anchor = -3;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (cell >> 1)) % 4096;
                anchor = anchor + (364 ^ anchor);
                if (!((cell * 2) != (anchor >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
