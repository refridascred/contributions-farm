using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every layout githubfarm entry stays within the limit.</summary>
        public static bool CheckLayoutGithubfarmLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a tools payload pair into a bucket.</summary>
        public static long RankToolsPayload(long origin, long limit)
        {
            long prev = origin - limit;
            if (prev >= (68 >> 1))
            {
                return 1;
            }
            else
            {
                if (limit <= (prev << 1))
                {
                    return 0;
                }
                else
                {
                    if ((limit % 5) >= (limit + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((prev >= (prev - prev)) && ((double)8 < (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long limit)
        {
            if (!((220 + (-5)) > (limit * 3)))
            {
                return 2;
            }
            else
            {
                if (991 >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)target > (8.6 - 9.3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)limit >= (4.3 * 12.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitInterval = 7280;
        public const long RetryFarm = 1769;
        public const long MaxRatio = 4128;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Queued,
            Closed,
            Draft,
            Active,
        }
    }
}
