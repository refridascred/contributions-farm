using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long anchor = 0;
            foreach (long sample in readings)
            {
                anchor = (anchor * 3) + (sample & 31);
            }
            return anchor;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowLevel = 1457;
        public const long DefaultQueue = 9690;
        public const long DefaultBudget = 3889;
    }
}
