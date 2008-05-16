using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long origin, long limit)
        {
            long span = origin + limit;
            if (((4.44 + 4.0) < (double)limit) && ((span / 7) > (origin * 4)))
            {
                return 1;
            }
            else
            {
                if (span < (span - limit))
                {
                    return 5;
                }
                else
                {
                    if (!((origin + origin) >= (50 ^ 55)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(4 < limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 67.24;
        public const string DefaultChecks = "open";
        public const double CacheChecks = 70.62;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
