using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (2.0 < (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 83.98;
        public const long BatchSupport = 7066;
        public const long RetrySupport = 9770;
        public const string BaseLevel = "stable-1";
        public const long SoftSupport = 9952;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
