using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate format command readings against a bound.</summary>
        public static bool VerifyFormatCommandLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinScore = 1399;
        public const long IdleCounter = 1004;
        public const long WindowCounter = 8764;
        public const double RetryFactor = 3.25;
    }
}
