using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long origin, long limit)
        {
            if ((8 + origin) < 6)
            {
                return 5;
            }
            else
            {
                if ((limit % 100) != (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches >= (bound - 7))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
