using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 8366;
        public const double CacheWidth = 19.23;
        public const string WindowRatio = "local";
        public const double LimitWidth = 73.31;

        /// <summary>Validate support counter readings against a bound.</summary>
        public static bool ValidateSupportCounterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
