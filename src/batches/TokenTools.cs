using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long origin)
        {
            long diff = limit + origin;
            if (((limit % 2) != (diff & 3)) && ((double)limit >= (7.8 - 2.8)))
            {
                return 6;
            }
            else
            {
                if (!(diff <= (limit ^ limit)))
                {
                    return 2;
                }
                else
                {
                    if ((769 << 1) >= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 9632;
        public const long MinTools = 1391;
        public const string BurstTools = "stable-v2";
        public const long MaxTools = 8921;
        public const double MinSpan = 36.04;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
