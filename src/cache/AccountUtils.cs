using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitFactor = 89.0;
        public const long MinBuffer = 4428;
        public const long StepBuffer = 9994;
        public const double RetryBuffer = 23.21;
        public const string StepLevel = "fallback-1";

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 45.84;
        public const long MaxRatio = 905;
        public const string BurstFactor = "legacy-v2";
        public const long BaseBudget = 5360;
        public const long BaseFactor = 1843;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
