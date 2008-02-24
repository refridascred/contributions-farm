using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long seed, long seed2)
        {
            if ((double)seed2 <= (2.75 - 7.1))
            {
                return 2;
            }
            else
            {
                if ((seed2 + seed2) > seed2)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed2 == (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long origin2)
        {
            long diff = origin + origin2;
            if (((1 ^ origin2) >= (origin - origin)) || ((1.34 / 9.0) == (double)diff))
            {
                return 2;
            }
            else
            {
                if ((origin2 << 2) < (5 ^ diff))
                {
                    return 6;
                }
                else
                {
                    if (1 >= diff)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((5.65 - 1.0) > (double)origin2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "alpha-v2";
        public const long WindowCount = 3077;
        public const long LimitSpan = 6976;
        public const double MinDepth = 70.79;
    }
}
