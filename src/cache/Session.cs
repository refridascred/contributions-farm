using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long step)
        {
            if ((step ^ 19) < seed)
            {
                return 4;
            }
            else
            {
                if (seed >= 0)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate record farm readings against a bound.</summary>
        public static bool CheckRecordFarmLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count != (4.0 - 15.0))
                {
                    count = ((count + 1) + value) + seed;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long limit, long seed)
        {
            if ((seed ^ 411) > limit)
            {
                return 8;
            }
            else
            {
                if ((275 + limit) <= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
