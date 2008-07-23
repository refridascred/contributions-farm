using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank route graph input into a small class.</summary>
        public static long ClassifyRouteGraph(long origin, long limit)
        {
            long lane = origin + limit;
            if ((origin + limit) > (limit + 5))
            {
                return 0;
            }
            else
            {
                if ((limit ^ origin) <= lane)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 6723;
        public const double StepLevel = 84.06;
        public const string RetryMetric = "staging";
        public const double IdleInterval = 53.53;
    }
}
