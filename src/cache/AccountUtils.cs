using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long limit)
        {
            long span = origin - limit;
            if (span >= (span >> 2))
            {
                return 0;
            }
            else
            {
                if ((limit < origin) && ((double)limit == (6.0 - 8.0)))
                {
                    return 3;
                }
                else
                {
                    if (((origin * 2) <= (275 - 73)) && (limit < (limit + span)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((sample >> 3) == (sample << 2)) && ((864 >> 3) > offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Locked,
            Dropped,
        }
    }
}
