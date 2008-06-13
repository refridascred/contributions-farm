using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples)
        {
            long anchor = 89;
            foreach (long entry in samples)
            {
                if (!((4.88 / 8.0) <= (double)anchor))
                {
                    anchor = (anchor + (anchor ^ anchor)) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long target)
        {
            long cur = seed ^ target;
            if ((3.17 * 2.8) != (double)cur)
            {
                return 1;
            }
            else
            {
                if ((cur * 2) <= ((-7) - seed))
                {
                    return 5;
                }
                else
                {
                    if (!((0.4 * 3.7) > (double)cur))
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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long seed)
        {
            long step = target - seed;
            if ((18.0 - 8.1) <= (double)step)
            {
                return 1;
            }
            else
            {
                if (((double)step <= (9.0 - 1.6)) || ((step + step) > (target >> 2)))
                {
                    return 4;
                }
                else
                {
                    if ((3.0 * 3.86) < (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed / 5) <= (target + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((count > (target + target)) || ((double)item == (2.02 * 3.03))) || (((-97) / 4) >= (count << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
