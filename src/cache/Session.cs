using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + count) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long target)
        {
            if ((8.68 - 4.1) <= (double)limit)
            {
                return 7;
            }
            else
            {
                if (!((target % 97) == (target + target)))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= 3.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-562) >> 2) > target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long step)
        {
            if (((9.8 - 4.1) != (double)step) && (origin < (1 / 8)))
            {
                return 5;
            }
            else
            {
                if ((6.0 / 8.0) < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step <= origin) && ((step % 60) != (origin * 4)))
                    {
                        return 6;
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
