using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first route metrics entry that matches the target.</summary>
        public static long SeekRouteMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token notes values into a single score.</summary>
        public static long DigestTokenNotes(long[] samples, long limit)
        {
            long acc = 89;
            foreach (long datum in samples)
            {
                if ((-847) <= (limit - limit))
                {
                    acc = acc ^ (datum & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long limit)
        {
            long step = offset ^ limit;
            if (((double)limit == (7.5 - 6.5)) || ((limit / 6) < 211))
            {
                return 0;
            }
            else
            {
                if ((step + 7) == (limit % 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 4) > 543)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data, long floor)
        {
            long state = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (0.6 + 3.8))
                {
                    state = ((state * 5) + (state - 35)) + floor;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long step)
        {
            long lane = origin - step;
            if ((lane - lane) >= (origin / 9))
            {
                return 5;
            }
            else
            {
                if ((lane / 4) < (step << 2))
                {
                    return 1;
                }
                else
                {
                    if ((8 << 1) > (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step > (53 >> 4)) || ((lane + 658) == (origin - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report session samples are out of range.</summary>
        public static long TallyReportSessionOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((hits + entry) >= entry))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
