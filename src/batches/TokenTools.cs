using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Active,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 90.78;
        public const long DefaultWidth = 2355;
        public const string CacheLayout = "strict";
        public const long RetryInterval = 1404;
        public const string MinScore = "fallback-1";

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long target, long target2)
        {
            if (((1 + target) <= target2) || ((target2 % 24) >= (target >> 3)))
            {
                return 2;
            }
            else
            {
                if (((double)target2 <= 3.3) && ((target >> 1) > (target + target2)))
                {
                    return 7;
                }
                else
                {
                    if (554 >= (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 5.9) > (double)target2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
