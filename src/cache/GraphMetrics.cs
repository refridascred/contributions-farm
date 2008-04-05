using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a entry filter pair into a bucket.</summary>
        public static long RankEntryFilter(long limit, long step)
        {
            if ((step >= (step >> 5)) || ((limit % 60) > (limit >> 1)))
            {
                return 3;
            }
            else
            {
                if (((double)limit >= (8.72 + 12.0)) || (limit <= (step ^ step)))
                {
                    return 5;
                }
                else
                {
                    if ((step % 16) < (limit - 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (7.1 >= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((-204) << 3) != (tally - reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9121;
        public const long WindowFactor = 9699;
        public const long CacheSize = 8867;
        public const long WindowTimeout = 5453;
        public const long IdleProfile = 4375;

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long target, long floor)
        {
            if ((floor - floor) < (27 * 3))
            {
                return 6;
            }
            else
            {
                if ((floor + (-579)) <= floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a githubfarm contributi pair into a bucket.</summary>
        public static long BucketGithubfarmContributi(long origin, long offset)
        {
            if (origin < (offset + origin))
            {
                return 6;
            }
            else
            {
                if (!((origin - origin) < (offset + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (7.0 * 13.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin << 1) <= (offset << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
