using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long seed)
        {
            if (78 > (seed + seed))
            {
                return 4;
            }
            else
            {
                if ((origin * 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((6.0 * 20.0) >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9 + seed) >= (48 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 5495;
        public const long BatchStats = 3356;
        public const long RetryStats = 8585;
    }
}
