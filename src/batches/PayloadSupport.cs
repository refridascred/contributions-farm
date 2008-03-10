using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank queue stream input into a small class.</summary>
        public static long SortQueueStream(long step, long floor)
        {
            long cur = step + floor;
            if (11.0 >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((cur + 707) <= (cur >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (7.7 - 20.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            long slot = origin ^ offset;
            if ((offset - slot) <= (356 - origin))
            {
                return 0;
            }
            else
            {
                if (((6.5 - 20.0) != (double)offset) && ((offset - offset) > (origin + 772)))
                {
                    return 8;
                }
                else
                {
                    if ((slot % 97) <= offset)
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

        /// <summary>Measure how many githubfarm cache samples are out of range.</summary>
        public static long TallyGithubfarmCacheHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((9.79 - 20.0) > (double)origin)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
