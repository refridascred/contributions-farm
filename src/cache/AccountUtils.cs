using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate context notes samples.</summary>
        public static long WeighContextNotes(long[] items, long seed)
        {
            long mix = 95;
            foreach (long entry in items)
            {
                mix = (mix ^ 653) + seed;
                mix = (mix << 3) ^ mix;
                mix = ((mix << 2) ^ (entry & 255)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryFactor = 3.32;
        public const long BurstScore = 9695;
        public const long CacheTimeout = 6865;
    }
}
