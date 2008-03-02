using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next cache account value from a seed.</summary>
        public static long SeriesCacheAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (acc % 3)) % 1000;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count % 10) >= (count / 6))
                {
                    count = ((count + 3) ^ item) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the format report series from a seed.</summary>
        public static long IterateFormatReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin >= mix) && ((28 + mix) != (long)i))
                {
                    mix = (mix + 652) % 101;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Synced,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
