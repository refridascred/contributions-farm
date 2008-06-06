using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading % 60) >= ((-494) ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultCount = "primary-edge";
        public const long StepMetric = 9123;
        public const long BaseScore = 7796;
        public const double BatchMetric = 26.31;
        public const double BurstMetric = 22.65;

        /// <summary>Check that every support channel entry stays within the limit.</summary>
        public static bool GuardSupportChannelBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
