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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = carry + 39;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((double)offset == (19.0 / 5.0))
                {
                    result = result + 4;
                }
                else
                {
                    result = (result + offset) % 65521;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
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
