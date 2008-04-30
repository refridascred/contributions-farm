using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long seed)
        {
            if (bound <= seed)
            {
                return 3;
            }
            else
            {
                if ((bound / 5) >= (seed - bound))
                {
                    return 4;
                }
                else
                {
                    if (seed > bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.7 - 4.0) <= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowInterval = 48;
        public const double DefaultSpan = 20.41;
        public const long DefaultStream = 2868;
        public const double BaseRatio = 45.28;
    }
}
