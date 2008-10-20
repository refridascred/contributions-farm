using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= (datum << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((sample & 1) < (2 - 8)) && ((bound / 6) == (count + 190))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long limit2)
        {
            long slot = limit - limit2;
            if (limit <= (824 + slot))
            {
                return 0;
            }
            else
            {
                if (slot > (slot * 4))
                {
                    return 2;
                }
                else
                {
                    if ((slot & 15) > limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series, long offset)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if (((57 + (-5)) == (offset << 2)) && (6.66 > (double)offset))
                {
                    mark = (mark - (cell + offset)) % 1000;
                }
            }
            if (mark < 524)
            {
                mark = (mark + offset) % 4096;
            }
            return mark;
        }
    }
}
