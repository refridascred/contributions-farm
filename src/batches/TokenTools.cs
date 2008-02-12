using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a account channel value against two limits.</summary>
        public static long SortAccountChannel(long origin, long floor)
        {
            if (floor > (origin & 63))
            {
                return 8;
            }
            else
            {
                if ((8.8 - 5.4) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (floor > (origin >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((19.0 / 6.0) < (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleLevel = 4873;
        public const double MinBudget = 26.5;
        public const long BurstScore = 8744;
        public const long BaseCache = 791;
        public const long WindowCache = 1787;

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepDepth = "alpha-1";
        public const long CacheMetric = 7033;
        public const string WindowMetric = "latest";
    }
}
