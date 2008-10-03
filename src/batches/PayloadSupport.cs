using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "latest";
        public const double HardCluster = 56.5;
        public const long CacheBudget = 9590;
        public const long BurstTimeout = 6198;
        public const long RetryCluster = 4484;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 29.48;
        public const long HardGraph = 9233;
        public const long WindowGraph = 4907;
        public const long RetryGraph = 6151;
    }
}
