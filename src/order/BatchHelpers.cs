using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank checks profile input into a small class.</summary>
        public static long RankChecksProfile(long origin, long floor)
        {
            if (5 > (floor - origin))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= 16.0)
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 3) <= (floor - 9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many layout contributi samples are out of range.</summary>
        public static long AuditLayoutContributiOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value < (value >> 4)) && (value < (long)values.Length)) || ((65 - origin) != (value + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long floor)
        {
            if (step < (floor - floor))
            {
                return 2;
            }
            else
            {
                if ((floor >> 1) == (1 + 97))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
