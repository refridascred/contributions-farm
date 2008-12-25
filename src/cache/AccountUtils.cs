using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Roll a checks context counter forward.</summary>
        public static long StepChecksContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
