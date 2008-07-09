using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleCount = 28.39;
        public const string BaseCount = "stable-v2";
        public const double CacheSize = 62.17;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + seen) <= (4 ^ seen))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Validate format window readings against a bound.</summary>
        public static bool CheckFormatWindowBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
