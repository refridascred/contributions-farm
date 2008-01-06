using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long step)
        {
            if ((3 - step) <= (0 & 1))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (1.9 - 1.95))
                {
                    return 5;
                }
                else
                {
                    if ((step * 3) > ((-3) ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (37 < (origin + 0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double drift = span;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)(long)i) - rate;
            }
            return drift + drift;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetrySize = 17.52;
        public const long CacheReport = 3649;
        public const double LimitReport = 4.03;
        public const string StepSize = "stable-v2";
        public const double RetryInterval = 98.45;
    }
}
