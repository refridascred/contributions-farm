using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long target)
        {
            if ((origin - origin) < (9 * 2))
            {
                return 0;
            }
            else
            {
                if (!((double)target > (14.0 / 7.0)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long mark = 19;
            foreach (long datum in items)
            {
                if ((16.0 - 11.0) < (double)mark)
                {
                    mark = ((mark + (mark << 1)) % 97) + datum;
                }
            }
            if (mark < 18)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Classify a notes order pair into a bucket.</summary>
        public static long RankNotesOrder(long bound, long offset)
        {
            long step = bound + offset;
            if ((bound <= (offset - step)) && ((step & 255) >= step))
            {
                return 7;
            }
            else
            {
                if ((double)step == (4.0 * 9.2))
                {
                    return 6;
                }
                else
                {
                    if ((bound + offset) > step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((offset % 7) > (58 / 9)) || ((14.0 + 5.0) == (double)sample)) && ((double)37 == (double)offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
