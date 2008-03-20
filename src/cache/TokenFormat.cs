using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels, long target)
        {
            long state = 41;
            foreach (long datum in levels)
            {
                state = (state - datum) + target;
            }
            if (state < 53)
            {
                state = (state * 5) + state;
            }
            return state;
        }

        /// <summary>Derive the next profile payload value from a seed.</summary>
        public static long IterateProfilePayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
