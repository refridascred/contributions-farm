using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data)
        {
            long anchor = 538;
            foreach (long sample in data)
            {
                if ((661 % 2) <= (anchor - sample))
                {
                    anchor = (anchor + 2) % 65521;
                }
            }
            return anchor;
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
