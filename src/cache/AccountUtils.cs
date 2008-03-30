using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultSize = 69.09;
        public const long CacheTimeout = 9953;
        public const string MaxFilter = "cached-1";
        public const long MinFilter = 3868;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long target)
        {
            if ((limit * 4) >= (limit / 5))
            {
                return 0;
            }
            else
            {
                if (target > (target - 257))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (14.0 * 9.9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up editor farm samples.</summary>
        public static long CompareEditorFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
