using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryLevel = 1421;
        public const long DefaultSupport = 5844;
        public const long DefaultSize = 2707;
        public const string RetryTimeout = "open-1";
        public const long BurstSize = 8401;

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 2755;
        public const long RetryFactor = 4528;
        public const double BaseCommand = 74.97;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ (offset / 9)) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
