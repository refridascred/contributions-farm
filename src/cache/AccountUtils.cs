using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((700 & 127) < (hits - limit)) && (limit >= (limit + limit)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Rank schema counter input into a small class.</summary>
        public static long RankSchemaCounter(long floor, long offset)
        {
            if ((1.4 - 7.97) == (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((double)offset != (5.0 + 8.7)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen << 1) > (seen * 3))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
