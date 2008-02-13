using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a session schema value against two limits.</summary>
        public static long BucketSessionSchema(long seed, long seed2)
        {
            if ((seed + seed) <= (seed2 >> 4))
            {
                return 4;
            }
            else
            {
                if (87 >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (double)seed2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((11.0 + 8.7) >= (double)seed)
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
        }
    }
}
