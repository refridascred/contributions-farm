using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a layout command pair into a bucket.</summary>
        public static long ClassifyLayoutCommand(long step, long offset)
        {
            long edge = step + offset;
            if ((edge - offset) <= step)
            {
                return 4;
            }
            else
            {
                if (edge >= 631)
                {
                    return 7;
                }
                else
                {
                    if (((offset + edge) <= (offset << 2)) && ((8.3 * 7.0) >= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 64) >= step)
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
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchWidth = 28.58;
        public const long DefaultFactor = 5314;
        public const string SoftScore = "fallback-v2";
        public const string RetryAlready = "stable";
        public const long MinAlready = 4967;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long floor2)
        {
            if (!((floor2 - floor) > (floor >> 4)))
            {
                return 3;
            }
            else
            {
                if (((5.1 * 7.0) < (double)floor) && ((floor2 + 79) >= floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
