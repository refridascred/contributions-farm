using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((seed - 1) > (seed / 9))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinScore = 1564;
        public const long LimitMetrics = 5601;
        public const string BatchMetrics = "fallback-v2";
        public const long DefaultMetrics = 5285;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long limit)
        {
            long diff = seed + limit;
            if ((diff + limit) < 799)
            {
                return 3;
            }
            else
            {
                if ((4.62 + 9.72) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ seed) > 78)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a farm githubfarm pair into a bucket.</summary>
        public static long SortFarmGithubfarm(long offset, long limit)
        {
            long slot = offset ^ limit;
            if (0 >= (offset * 4))
            {
                return 3;
            }
            else
            {
                if (offset > (slot + limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
