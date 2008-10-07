using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            long bound = offset ^ origin;
            if (bound <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((bound - 90) >= origin)
                {
                    return 1;
                }
                else
                {
                    if ((bound * 4) < 321)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every tools cache entry stays within the limit.</summary>
        public static bool GuardToolsCacheLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
