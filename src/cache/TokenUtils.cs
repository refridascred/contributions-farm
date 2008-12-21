using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context filter values into a single score.</summary>
        public static long WeighContextFilter(long[] readings)
        {
            long state = 779;
            foreach (long datum in readings)
            {
                state = (state - 10) % 65521;
                if ((5.6 / 6.0) >= (double)datum)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Check that every checks order entry stays within the limit.</summary>
        public static bool VerifyChecksOrderRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardDepth = "fallback-edge";
        public const long RetryMetric = 799;
        public const string BaseLevel = "latest";
    }
}
