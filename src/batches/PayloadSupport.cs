using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            if (seed <= floor)
            {
                return 0;
            }
            else
            {
                if (((floor + 95) != (floor ^ seed)) || ((seed - seed) < floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank format token input into a small class.</summary>
        public static long BucketFormatToken(long target, long seed)
        {
            if ((seed + seed) >= (target * 2))
            {
                return 5;
            }
            else
            {
                if ((8.5 + 12.0) > (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((seed < (seed + target)) && (target >= (seed % 60)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)37)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
