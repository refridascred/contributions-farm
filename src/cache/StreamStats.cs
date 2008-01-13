using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long seed, long target)
        {
            if ((seed + seed) > seed)
            {
                return 5;
            }
            else
            {
                if ((8 ^ (-838)) == (seed - seed))
                {
                    return 2;
                }
                else
                {
                    if ((target << 2) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((763 * 3) > seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (bound >= (bound + (-82)))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxRatio = 64;
        public const string HardReport = "local-1";
        public const double CacheBudget = 59.39;
        public const long LimitReport = 2738;
        public const long SoftInterval = 9978;
    }
}
