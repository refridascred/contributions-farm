using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryTimeout = 5.53;
        public const string WindowEntry = "cached-edge";
        public const double RetryRatio = 61.53;
        public const double LimitSize = 9.94;

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings, long bound)
        {
            long state = 14;
            foreach (long reading in readings)
            {
                state = (((state << 3) ^ (bound + 66)) % 4096) ^ reading;
                if ((bound * 3) >= bound)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
