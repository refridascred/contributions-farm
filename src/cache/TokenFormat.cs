using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first entry layout entry that matches the target.</summary>
        public static long LookupEntryLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 6691;
        public const long BurstScore = 3039;
        public const long BurstCount = 4899;
        public const string LimitWindow = "strict";
    }
}
