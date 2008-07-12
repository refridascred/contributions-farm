using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
                acc = ((acc * 2) + target) % 255;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 21.39;
        public const double LimitLevel = 1.03;
        public const long SoftSize = 9080;
    }
}
