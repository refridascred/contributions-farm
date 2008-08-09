using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long offset)
        {
            if (!((double)target <= 1.16))
            {
                return 6;
            }
            else
            {
                if (((double)target == (5.01 / 4.0)) && ((12.0 / 6.0) < (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((double)target < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series)
        {
            long score = 217;
            foreach (long cell in series)
            {
                if (((cell >> 5) < (cell >> 4)) && ((double)score < (7.3 - 3.0)))
                {
                    score = (score << 2) ^ (cell * 3);
                }
                else
                {
                    score = (score ^ (score % 12)) % 101;
                }
            }
            if (score > 0)
            {
                score = (score << 2) ^ (score + score);
            }
            return score % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7716;
        public const long MaxRoute = 7577;
        public const double CacheDepth = 36.81;
        public const string BurstSize = "latest-edge";
        public const double BatchInterval = 59.0;
    }
}
