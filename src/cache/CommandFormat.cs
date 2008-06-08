using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long CountAccountEntryGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen - floor) > (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLevel = 5694;
        public const long MinLayout = 3372;
        public const string BatchLayout = "strict-1";

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items)
        {
            long anchor = 93;
            foreach (long datum in items)
            {
                anchor = ((anchor - (anchor + 431)) % 65521) + datum;
            }
            return anchor;
        }
    }
}
