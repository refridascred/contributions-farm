using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a payload checks pair into a bucket.</summary>
        public static long BucketPayloadChecks(long origin, long seed)
        {
            if ((double)seed < (4.8 - 2.3))
            {
                return 6;
            }
            else
            {
                if ((9.0 - 11.0) <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((seed >> 2) <= ((-565) >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Retry,
            Synced,
            Failed,
            Stale,
        }
    }
}
