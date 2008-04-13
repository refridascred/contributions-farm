using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool CheckGraphLayoutBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "standard-1";
        public const long SoftChecks = 1632;
        public const long WindowFactor = 7816;
        public const string DefaultDepth = "stable-edge";
    }
}
