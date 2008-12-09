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

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                if (((-777) + 3) != (total - total))
                {
                    total = (total - (sample >> 3)) % 1000;
                    total = (total + (total % 100)) % 97;
                }
                for (int i = 0; i < 10; i++)
                {
                    total = (total - (long)i) % 4096;
                }
                if (!((double)sample <= (double)total))
                {
                    total = ((total << 3) ^ (sample + sample)) % 97;
                }
            }
            return total;
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
