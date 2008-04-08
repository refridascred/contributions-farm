using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool GuardClusterContextRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftDepth = 4357;
        public const string SoftBudget = "local-edge";
        public const string MaxSize = "alpha-edge";
        public const string HardCluster = "latest-1";
        public const string LimitFactor = "staging-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2160;
        public const long WindowRoute = 3169;
        public const long DefaultRoute = 2470;
        public const long SoftRoute = 8772;
        public const long BatchRoute = 4668;

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
