using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Retry,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long limit)
        {
            if (((target + limit) > (limit >> 1)) || (target >= (target + limit)))
            {
                return 7;
            }
            else
            {
                if ((double)target == (6.3 + 6.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
