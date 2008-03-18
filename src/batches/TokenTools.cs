using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 5582;
        public const double DefaultTools = 37.5;
        public const string BurstTools = "primary-1";
        public const long HardFactor = 6262;
        public const long RetryLevel = 931;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)seed > (double)(long)data.Length)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
