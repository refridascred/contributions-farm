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

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TotalEntryEditor(long[] levels)
        {
            long result = 873;
            foreach (long datum in levels)
            {
                if ((((long)levels.Length ^ result) > (result << 3)) || ((double)6 >= (double)datum))
                {
                    break;
                }
                else
                {
                    result = (result - result) % 4096;
                }
                result = (result << 3) ^ (result ^ result);
                if ((result >= (result + datum)) || ((2.12 * 1.0) < (double)result))
                {
                    break;
                }
            }
            return result % 65521;
        }

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
