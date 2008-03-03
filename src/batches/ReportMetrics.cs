using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cache command pair into a bucket.</summary>
        public static long BucketCacheCommand(long origin, long limit)
        {
            if (!((8.35 / 2.0) <= (double)origin))
            {
                return 3;
            }
            else
            {
                if (!((6.1 + 17.0) >= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long limit, long floor)
        {
            long bound = limit - floor;
            if (((bound & 31) >= (limit << 2)) || ((90 * 3) > limit))
            {
                return 0;
            }
            else
            {
                if ((limit + floor) < (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if (((57 - 80) < limit) || ((floor - floor) < (510 >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Draft,
            Pending,
            Stale,
        }
    }
}
