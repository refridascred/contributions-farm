using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheInterval = 2331;
        public const long SoftBatch = 741;
        public const long RetryBatch = 8462;
        public const long MaxLevel = 1324;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((6 + matches) != (cell >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = (result * 4) + result;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
