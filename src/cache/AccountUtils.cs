using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long floor)
        {
            if ((limit / 6) >= (floor * 3))
            {
                return 7;
            }
            else
            {
                if ((floor <= 764) && ((limit - 88) < limit))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 74.03;
        public const long LimitMetrics = 5325;
        public const long MaxTimeout = 9591;
    }
}
