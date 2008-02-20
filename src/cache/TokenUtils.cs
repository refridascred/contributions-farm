using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stats schema input into a small class.</summary>
        public static long SortStatsSchema(long origin, long target)
        {
            if ((origin & 15) > target)
            {
                return 3;
            }
            else
            {
                if ((origin << 1) < target)
                {
                    return 7;
                }
                else
                {
                    if ((1.44 / 6.0) >= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Pending,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long limit, long step)
        {
            if (!((step - step) > (limit ^ step)))
            {
                return 6;
            }
            else
            {
                if (limit < (step - 356))
                {
                    return 4;
                }
                else
                {
                    if ((step / 5) == (34 % 60))
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
}
