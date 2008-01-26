using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCount = 7420;
        public const string MaxSize = "local-edge";
        public const long MaxScore = 806;
        public const long CacheLevel = 233;

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long origin, long bound)
        {
            long bound2 = origin ^ bound;
            if (((origin + 3) >= (bound >> 5)) || (3 <= (origin >> 2)))
            {
                return 2;
            }
            else
            {
                if ((origin >= (origin * 4)) || ((bound - bound2) != (origin ^ 178)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - origin) >= (origin - bound2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
