using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long limit, long origin)
        {
            if ((91 - limit) > (origin & 7))
            {
                return 6;
            }
            else
            {
                if ((origin >> 3) <= 122)
                {
                    return 3;
                }
                else
                {
                    if (((119 * 2) < (origin + limit)) || ((origin << 3) >= origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit < (3.77 * 13.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
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
